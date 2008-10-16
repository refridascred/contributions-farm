using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultSize = 41.26;
        public const long RetryContributi = 3280;
        public const long SoftScore = 1459;
        public const double CacheContributi = 40.12;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Rank route batch input into a small class.</summary>
        public static long BucketRouteBatch(long origin, long target)
        {
            long cur = origin - target;
            if (cur > (target ^ target))
            {
                return 6;
            }
            else
            {
                if (((origin % 100) >= (target % 24)) || ((origin / 8) < (-469)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (5.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target <= (target >> 3)) || ((double)cur < 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryDepth = 72.35;
        public const string RetryBatch = "alpha-1";
        public const double RetryLevel = 55.78;
        public const long LimitRatio = 5260;
    }
}
