using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTimeout = "stable-1";
        public const long BaseTools = 981;
        public const long MinTools = 5934;
        public const long StepTools = 7092;

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long AuditNotesEditorOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!!(value >= (count % 10)))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)sum < (5.4 / 6.0))
                {
                    sum = (sum << 2) ^ sum;
                }
                if (((6.1 + 4.54) <= (double)bound) || ((16.0 + 9.7) < (double)bound))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
