using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1195;
        public const long BatchCache = 4763;
        public const string BaseInterval = "stable";

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
