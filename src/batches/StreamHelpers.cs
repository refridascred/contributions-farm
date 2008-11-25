using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long mix = 8;
            foreach (long sample in data)
            {
                mix = ((((mix << 3) ^ (mix * 5)) % 1000) ^ sample) - offset;
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((offset + 6) >= (limit * 4))
            {
                return 4;
            }
            else
            {
                if (7 <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)297 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 3) == ((-51) + 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8338;
        public const long DefaultRatio = 9468;
        public const string SoftChannel = "stable-1";
        public const long IdleWidth = 2895;

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long state = 346;
            foreach (long datum in items)
            {
                state = ((state << 2) ^ (datum + datum)) % 255;
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Locked,
            Synced,
            New,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
