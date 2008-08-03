using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Dropped,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double weight = gain;
            if (weight > (3.3 + weight))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Match up route profile samples.</summary>
        public static long OverlapRouteProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
