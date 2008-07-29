using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long ClassifyPayloadCommits(long seed, long bound)
        {
            long step = seed + bound;
            if (((double)seed == (7.9 * 1.59)) || ((double)seed >= 6.0))
            {
                return 7;
            }
            else
            {
                if (((double)bound != (double)seed) || (seed <= (step - seed)))
                {
                    return 2;
                }
                else
                {
                    if (((seed + step) <= seed) || (bound >= (seed - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (7.4 <= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Paused,
            Done,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item == (5.0 - 6.98))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
