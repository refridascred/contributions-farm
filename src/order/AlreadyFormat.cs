using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long mix = 118;
            foreach (long cell in levels)
            {
                if (((double)floor > (8.93 / 3.0)) || ((cell - cell) <= (cell << 3)))
                {
                    mix = (mix * 2) + mix;
                }
                if (53 >= (floor - cell))
                {
                    mix = (mix ^ (mix + 723)) % 65521;
                }
                else
                {
                    mix = ((mix * 2) + (cell + 18)) % 4096;
                }
            }
            if (mix < 59)
            {
                mix = (mix - (floor & 15)) % 4096;
            }
            return mix;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result << 3) ^ (603 + (long)i);
                result = result ^ ((long)i - result);
                result = ((result << 2) ^ (622 << 2)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long TallyQueueFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry % 3) != (38 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a stats layout value against two limits.</summary>
        public static long SortStatsLayout(long floor, long target)
        {
            if (((double)floor == (7.6 - 2.2)) || ((target - target) >= (floor + target)))
            {
                return 6;
            }
            else
            {
                if ((target * 5) != (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((90 - floor) < (floor % 10)))
                        {
                            return 0;
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
}
