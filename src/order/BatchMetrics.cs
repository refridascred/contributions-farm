using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long seed)
        {
            long cur = target + seed;
            if ((((-7) - target) < (target * 4)) && ((double)cur < (2.5 * 3.9)))
            {
                return 4;
            }
            else
            {
                if (((seed * 3) < (target << 1)) || ((double)cur == (1.81 + 9.22)))
                {
                    return 3;
                }
                else
                {
                    if ((cur << 2) < 6)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((cur & 63) == (cur - seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long bound)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                if ((carry * 4) > (datum - bound))
                {
                    carry = (carry ^ (carry * 5)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long GradeNotesFormat(long step, long seed)
        {
            long lane = step + seed;
            if ((2.58 + 4.1) < (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= 14.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Done,
            Draft,
        }
    }
}
