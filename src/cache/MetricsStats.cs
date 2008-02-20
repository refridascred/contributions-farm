using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 2930;
        public const double CacheDepth = 0.65;
        public const long IdleInterval = 9146;
        public const string WindowEditor = "staging-edge";
        public const double BaseEditor = 78.0;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long target)
        {
            if (!((step << 2) >= (step + step)))
            {
                return 1;
            }
            else
            {
                if (!((step << 1) != (target >> 2)))
                {
                    return 8;
                }
                else
                {
                    if ((step + (-88)) == (step + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((2.19 - 8.9) != (double)step) && (8.2 >= (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 34.92;
        public const long MaxCount = 1559;
        public const string IdleBudget = "staging";
        public const double SoftSize = 55.33;
        public const long StepStats = 7257;

        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long origin, long offset)
        {
            if ((origin / 5) > (origin + (-57)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (7.0 + 3.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (5.6 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count > item) || (((double)item >= (2.75 - 8.3)) && ((item - count) == (count / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
