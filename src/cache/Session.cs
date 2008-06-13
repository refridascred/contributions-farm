using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long ClassifyWindowGraph(long floor, long seed)
        {
            if (10.0 > (double)seed)
            {
                return 3;
            }
            else
            {
                if (((2.03 * 0.97) >= (double)floor) || (0.8 <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double weight = (rate - offset) / 7.0;
            if (weight >= offset)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (weight * 5.3);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
