using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels, long seed)
        {
            long acc = 80;
            foreach (long entry in levels)
            {
                acc = acc - acc;
                if ((seed >> 5) == (650 - seed))
                {
                    acc = (acc - (entry >> 5)) % 101;
                }
                acc = (acc - (6 & 127)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                long offset2 = offset;
                if (!((6.5 + 9.0) > (double)mix))
                {
                    long next = offset2;
                    mix = mix - (next - (long)i);
                    continue;
                }
                else
                {
                    offset2 = ((offset2 * 4) + offset2) % 4096;
                    mix = mix ^ offset2;
                }
                if ((8.41 - 1.13) < (double)offset)
                {
                    mix = mix ^ (offset2 + offset2);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
