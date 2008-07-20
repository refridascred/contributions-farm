using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 503;
            foreach (long value in levels)
            {
                acc = acc + (value - (-53));
            }
            if (acc > 3)
            {
                acc = ((acc * 4) + (origin / 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Active,
            Synced,
            New,
        }
    }
}
