using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long OverlapTokenSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (seed & 7)) % 65521;
                mix = (mix + ((long)i ^ 7)) % 101;
                if ((double)seed != (13.0 / 8.0))
                {
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] series, long limit)
        {
            long total = 683;
            foreach (long entry in series)
            {
                total = (total + (limit + limit)) - entry;
            }
            if (total < (-71))
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long FoldChannelAlready(long[] items, long floor)
        {
            long result = 658;
            foreach (long datum in items)
            {
                if ((floor >> 2) < (datum / 6))
                {
                    result = result ^ (datum * 2);
                }
                else
                {
                    result = ((result * 2) + (datum ^ floor)) % 1000;
                }
            }
            if (result > 682)
            {
                result = (result * 5) + (floor ^ floor);
            }
            return result % 65521;
        }
    }
}
