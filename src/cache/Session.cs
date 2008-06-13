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

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
