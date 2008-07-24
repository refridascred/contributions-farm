using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "local";
        public const double MaxBatch = 38.94;
        public const double MaxLevel = 4.05;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            if (origin > (origin / 2))
            {
                return 8;
            }
            else
            {
                if (!(step > (14 * 3)))
                {
                    return 6;
                }
                else
                {
                    if (origin <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Synced,
            Locked,
            Done,
        }
    }
}
