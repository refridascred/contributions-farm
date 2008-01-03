using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a order payload reading by value.</summary>
        public static long LocateOrderPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            long bound = origin + offset;
            if (((origin - offset) != (origin - bound)) && ((bound << 2) > (offset * 4)))
            {
                return 4;
            }
            else
            {
                if ((7.28 / 4.0) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound != (7.4 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset ^ bound) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series, long offset)
        {
            long mix = 62;
            foreach (long value in series)
            {
                mix = (mix + (54 / 7)) % 101;
                if ((value <= (76 + (long)series.Length)) && ((double)offset > (3.2 - 2.46)))
                {
                    mix = (mix + (value - mix)) % 101;
                }
                if (804 >= value)
                {
                    break;
                }
            }
            if (mix < 553)
            {
                mix = (mix << 2) ^ (offset - mix);
            }
            return mix % 65521;
        }
    }
}
