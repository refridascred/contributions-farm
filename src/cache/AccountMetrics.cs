using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a tools checks pair into a bucket.</summary>
        public static long GradeToolsChecks(long bound, long seed)
        {
            if ((double)seed != (3.23 * 4.8))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((seed + seed) < bound) || (seed >= (seed + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed <= (seed ^ 815)) || (8.0 > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if (!((lane * 4) >= ((-410) >> 5)))
            {
                return 0;
            }
            else
            {
                if ((lane - offset) >= (target + offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if ((bound & 31) >= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + bound) > floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8317;
        public const long SoftCount = 4187;
        public const double BatchContext = 3.09;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
