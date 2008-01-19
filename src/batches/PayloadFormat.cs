using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long step)
        {
            if ((26 * 2) >= (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((5 - seed) > seed)
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels)
        {
            long mix = 291;
            foreach (long cell in levels)
            {
                mix = ((mix << 3) ^ cell) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
