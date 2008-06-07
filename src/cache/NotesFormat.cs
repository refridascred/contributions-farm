using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long offset, long floor)
        {
            long gap = offset - floor;
            if (((4.66 / 7.0) >= (double)offset) && ((offset << 2) >= (775 << 2)))
            {
                return 4;
            }
            else
            {
                if (offset > (gap + floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor + gap) > (offset - 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            long span = offset + bound;
            if ((span ^ offset) > (span + 159))
            {
                return 6;
            }
            else
            {
                if ((2.5 * 9.66) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((477 <= offset) || ((bound % 100) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
