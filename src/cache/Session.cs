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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long state = -8;
            foreach (long cell in levels)
            {
                state = ((state + (state * 5)) % 255) ^ cell;
                if (!(2 < (limit * 4)))
                {
                    state = (state << 3) ^ limit;
                }
            }
            return state % 1000;
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
