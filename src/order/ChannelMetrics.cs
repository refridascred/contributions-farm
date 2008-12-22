using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Failed,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long mix = 5;
            foreach (long item in items)
            {
                if ((floor + 8) == (floor & 127))
                {
                    mix = mix ^ (item - mix);
                }
            }
            return mix;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long delta = target + floor;
            if ((double)delta <= 20.0)
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (delta - 49))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (delta & 63)) || ((target / 4) < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.1 * 8.6) >= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
