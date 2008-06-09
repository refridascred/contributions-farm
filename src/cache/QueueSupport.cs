using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 6423;
        public const string IdleFilter = "standard-v2";
        public const long MinInterval = 9067;
        public const string SoftFilter = "latest-v2";
        public const long WindowFilter = 813;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((28 + 1) == (matches & 255)) && ((value >> 5) <= (value + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long offset = seed ^ step;
            if ((seed + 281) > step)
            {
                return 0;
            }
            else
            {
                if ((double)step >= 10.0)
                {
                    return 3;
                }
                else
                {
                    if (!((0 + seed) == (offset - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 7) < (1 % 8)) && ((step >> 3) > (offset + seed)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
