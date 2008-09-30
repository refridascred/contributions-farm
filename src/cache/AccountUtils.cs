using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Rank batches cache input into a small class.</summary>
        public static long SortBatchesCache(long step, long origin)
        {
            if (!((double)origin >= (2.1 / 9.0)))
            {
                return 6;
            }
            else
            {
                if (!((7 + step) <= (step % 16)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double ratio = (double)29;
            if (ratio < offset)
            {
                ratio = (ratio + offset) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 4.83) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
