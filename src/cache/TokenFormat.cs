using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen * 3) >= ((long)samples.Length + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Queued,
            Done,
            Retry,
            Closed,
        }
    }
}
