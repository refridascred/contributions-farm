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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double load = gain * 0.2;
            return (load + (load + gain)) + offset;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((78 ^ total) > total)
                {
                    total = (total ^ step) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
