using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                if ((double)cell < 3.9)
                {
                    anchor = ((anchor << 2) ^ (36 ^ cell)) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
