using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long mark = 2;
            foreach (long value in samples)
            {
                if ((mark + value) < (floor / 2))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark - (719 + value)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every cluster profile entry stays within the limit.</summary>
        public static bool VerifyClusterProfileBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 6673;
        public const double WindowBuffer = 90.82;
        public const long HardBuffer = 701;
        public const double SoftBuffer = 39.61;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long seed)
        {
            if ((seed ^ 109) >= (943 ^ (-555)))
            {
                return 0;
            }
            else
            {
                if ((seed + target) == (seed & 63))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed == (double)target) && ((seed + target) >= (target * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed % 97) >= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
