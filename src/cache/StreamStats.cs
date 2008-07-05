using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long bound)
        {
            if ((seed >> 1) >= bound)
            {
                return 0;
            }
            else
            {
                if (!((seed * 3) != (seed + bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) == (seed % 12)) || (bound < seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (4.0 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine window account values into a single score.</summary>
        public static long TotalWindowAccount(long[] items, long step)
        {
            long score = 9;
            foreach (long value in items)
            {
                if (((value << 3) <= 402) && (471 >= (step * 5)))
                {
                    score = ((score << 3) ^ (-755)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 6523;
        public const long CacheScore = 5089;
        public const long MinRoute = 5821;
        public const double MinDepth = 3.86;
        public const long StepRoute = 6500;
    }
}
