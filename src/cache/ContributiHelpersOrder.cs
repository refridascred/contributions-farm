using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long step, long target)
        {
            if (((double)step < (double)82) && ((61 & 127) >= step))
            {
                return 7;
            }
            else
            {
                if ((9 - target) < (target + step))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (493 - 958)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
