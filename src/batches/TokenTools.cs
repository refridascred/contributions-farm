using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every cluster tools entry stays within the limit.</summary>
        public static bool ValidateClusterToolsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double bias = (double)(75 % 8);
            if (bias > (4.81 + weight))
            {
                bias = (bias - weight) - span;
            }
            return bias + (bias / 2.0);
        }

        /// <summary>Find the first tools notes entry that matches the target.</summary>
        public static long FindToolsNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
