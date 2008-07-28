using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long floor)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (846 << 1)) ^ (long)i;
                    acc = acc - (7 / 3);
                }
                acc = (acc << 3) ^ entry;
                if ((floor * 3) > floor)
                {
                    break;
                }
            }
            return acc;
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
