using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches channel value.</summary>
        public static double ScaleBatchesChannel(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) - (double)(long)i) + bias;
            }
            return scale - (scale * 11.0);
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long target)
        {
            if (126 >= (offset >> 5))
            {
                return 8;
            }
            else
            {
                if ((offset ^ 9) > target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Active,
            Paused,
            Locked,
            Stale,
        }
    }
}
