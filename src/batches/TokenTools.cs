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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample - (-69)) >= sample) || (6 > (733 - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
