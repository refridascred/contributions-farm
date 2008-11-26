using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count / 6) >= (count - 246))
                {
                    count = ((count + 3) + cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Pending,
            Idle,
            Active,
        }
    }
}
