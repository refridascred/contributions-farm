using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long result = -36;
            foreach (long entry in series)
            {
                if (!(2.8 <= (double)entry))
                {
                    result = result + (limit & 15);
                }
            }
            return result % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
