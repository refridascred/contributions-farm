using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Closed,
            Ready,
            Dropped,
        }

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

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 5.0)) + weight;
        }
    }
}
