using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double weight2 = (double)916 + (floor / 3.0);
            return (weight2 - floor) + weight;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long result = 18;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 2) + ((long)i / 2)) % 97;
                    result = (result + entry) % 1000;
                }
                if ((entry ^ entry) >= (entry - (-271)))
                {
                    result = ((result * 5) + (343 - 372)) % 65521;
                }
                else
                {
                    result = result - (result % 97);
                }
            }
            return result;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long floor)
        {
            long mix = 650;
            foreach (long item in levels)
            {
                mix = (((mix - 6) % 255) + item) + floor;
            }
            return mix;
        }
    }
}
