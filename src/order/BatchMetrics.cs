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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long seed)
        {
            long total = 563;
            foreach (long value in readings)
            {
                if ((double)value >= 3.71)
                {
                    total = ((total - (total + value)) % 1000) - seed;
                }
            }
            return total;
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
