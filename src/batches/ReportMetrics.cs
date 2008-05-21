using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((mix + mix) > (target << 2))
                {
                    mix = (mix - (long)i) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            New,
            Paused,
            Idle,
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long RankAccountLayout(long floor, long seed)
        {
            if (((-380) - floor) != (floor & 1))
            {
                return 8;
            }
            else
            {
                if ((seed - seed) <= (seed + floor))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor < 11.0) && ((floor % 16) < (-991)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
