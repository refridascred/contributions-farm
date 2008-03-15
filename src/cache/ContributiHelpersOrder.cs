using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long limit)
        {
            long slot = target - limit;
            if ((target > (target - target)) || ((9.04 - 6.31) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((limit << 3) == (target / 6))
                {
                    return 6;
                }
                else
                {
                    if (target >= (5 & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot % 16) <= (target >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
