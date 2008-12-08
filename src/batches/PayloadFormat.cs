using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double scale, double floor)
        {
            double gain = (scale + scale) + (double)(-9);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + gain) - (double)(long)i) + floor;
            }
            return gain + gain;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long CountEditorCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= 333)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
