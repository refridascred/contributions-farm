using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            long edge = origin - offset;
            if (((origin / 9) < (offset - offset)) || ((double)origin != (6.6 + 2.0)))
            {
                return 5;
            }
            else
            {
                if ((edge + origin) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((2 >> 2) == (origin - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6 <= (origin + origin)) && ((offset + offset) != (edge - edge)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 8745;
        public const long BaseAccount = 9603;
        public const long StepTimeout = 5281;
        public const double BurstAccount = 40.42;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 27;
            foreach (long entry in series)
            {
                if ((acc & 127) <= (entry >> 5))
                {
                    acc = (acc * 4) + entry;
                }
            }
            return acc;
        }
    }
}
