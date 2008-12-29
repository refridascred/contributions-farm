using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 39.14;
        public const long IdleFactor = 5971;
        public const long IdleBatch = 4821;
        public const long DefaultBatch = 764;
        public const long StepBatch = 9913;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long seed)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = sum ^ (cell << 3);
                if (((sum + 32) == (seed & 3)) && ((double)seed > 3.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank session window input into a small class.</summary>
        public static long GradeSessionWindow(long target, long step)
        {
            long delta = target - step;
            if ((4.2 - 4.2) != (double)step)
            {
                return 2;
            }
            else
            {
                if ((delta + delta) == (6 - step))
                {
                    return 0;
                }
                else
                {
                    if ((target + step) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.5 * 2.64) < (double)delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Closed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 7680;
        public const double CacheContributi = 65.77;
        public const long LimitContributi = 8660;

        /// <summary>Classify a githubfarm layout pair into a bucket.</summary>
        public static long GradeGithubfarmLayout(long origin, long target)
        {
            if ((1 % 3) <= target)
            {
                return 8;
            }
            else
            {
                if ((target / 4) < (631 + target))
                {
                    return 2;
                }
                else
                {
                    if ((5.0 / 3.0) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 2) != (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
