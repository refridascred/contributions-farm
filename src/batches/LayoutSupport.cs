using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 9096;
        public const double StepInterval = 56.36;
        public const string MinContributi = "legacy";
        public const long BurstWidth = 2875;
        public const double BatchBudget = 63.32;

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double drift = (double)((-70) + 164);
            return ((drift + 0.5) + ratio) + floor;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long target)
        {
            long gap = offset - target;
            if (((gap % 24) == (target ^ gap)) && ((offset / 5) > offset))
            {
                return 2;
            }
            else
            {
                if ((double)target < 18.0)
                {
                    return 6;
                }
                else
                {
                    if (((3.4 / 5.0) > (double)gap) && ((target << 3) > (gap - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((gap & 7) != (offset + 294)) && (gap >= (gap / 2)))
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
    }
}
