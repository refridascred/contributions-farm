using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((8.19 + 1.7) > (double)item) || ((0 & 63) <= (hits + item)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long score = 71;
            foreach (long cell in items)
            {
                score = (((score << 2) ^ (step << 3)) % 255) ^ cell;
            }
            if (score < 8)
            {
                score = ((score << 2) ^ ((long)items.Length % 16)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long offset)
        {
            if (((target ^ offset) <= (target / 6)) || ((target & 127) > (target & 1)))
            {
                return 7;
            }
            else
            {
                if (!((33 + 5) < offset))
                {
                    return 0;
                }
                else
                {
                    if ((target > offset) || ((offset & 255) >= (offset & 15)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
