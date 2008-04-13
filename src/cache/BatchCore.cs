using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1372;
        public const double MaxEditor = 20.78;
        public const double DefaultRatio = 81.16;
        public const double LimitEditor = 49.52;
        public const long BaseEditor = 2412;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound2 - bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound ^ 970) >= bound2)
                {
                    return 7;
                }
                else
                {
                    if (!((85 + bound) > (bound + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 << 3) <= (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session window counter forward.</summary>
        public static long IterateSessionWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + acc) <= seed))
                {
                    acc = (acc << 3) ^ (seed ^ seed);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Dropped,
            Retry,
            Draft,
        }
    }
}
