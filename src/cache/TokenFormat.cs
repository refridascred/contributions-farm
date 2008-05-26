using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio + (double)99;
        }
    }
}
