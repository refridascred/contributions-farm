using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a entry session value against two limits.</summary>
        public static long SortEntrySession(long offset, long step)
        {
            long prev = offset - step;
            if (prev < (-89))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (4.4 + 9.0)) && ((step - offset) > (step & 63)))
                {
                    return 7;
                }
                else
                {
                    if (!((offset * 4) <= (prev & 31)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 12) <= (offset + 60))
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
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Synced,
            Paused,
        }
    }
}
