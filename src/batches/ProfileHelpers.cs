using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long floor)
        {
            long next = seed - floor;
            if (((floor << 2) < seed) || ((seed ^ next) >= (next + 44)))
            {
                return 7;
            }
            else
            {
                if (next < (-985))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 4) <= (next ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next & 3) < (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - seed) <= seed)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values, long origin)
        {
            long mark = 35;
            foreach (long reading in values)
            {
                if ((80 + origin) != (reading << 1))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
