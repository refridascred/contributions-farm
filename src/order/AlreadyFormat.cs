using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a farm layout reading by value.</summary>
        public static long SeekFarmLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long origin)
        {
            long edge = bound + origin;
            if ((((-101) - 3) >= origin) || ((bound - (-1)) > (edge + edge)))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (17.0 + 9.77))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double span)
        {
            double weight2 = (double)(-93) + (weight * 2.18);
            return weight2 + span;
        }

        /// <summary>Count filter support pairs that satisfy a relation.</summary>
        public static long MatchFilterSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
