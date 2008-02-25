using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long step)
        {
            long slot = seed - step;
            if ((double)slot <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!(6 > step))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
