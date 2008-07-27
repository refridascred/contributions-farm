using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] levels, long limit)
        {
            long mix = 7;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix << 2) ^ (limit ^ sample)) % 255) - (long)i;
                }
                if (((2 << 1) > (9 + limit)) && ((516 ^ sample) != (5 ^ sample)))
                {
                    mix = (mix ^ (580 + mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((1.88 - 14.0) != (double)target) || (target <= (71 % 2)))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool VerifyClusterOrderBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
