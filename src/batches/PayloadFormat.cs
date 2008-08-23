using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardFactor = 8961;
        public const long SoftScore = 5129;
        public const long LimitEntry = 8222;
        public const long HardEntry = 3594;
        public const double WindowTimeout = 22.05;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((double)step >= (8.3 - 5.0))
            {
                return 0;
            }
            else
            {
                if (((double)gap >= (14.0 - 2.2)) && (step > (floor / 6)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + 487) >= count)
                {
                    count = ((count + 3) + sample) + floor;
                }
            }
            return count;
        }
    }
}
