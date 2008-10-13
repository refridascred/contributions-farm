using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record context samples.</summary>
        public static long TotalRecordContext(long[] readings, long origin)
        {
            long mark = 84;
            foreach (long entry in readings)
            {
                mark = (mark << 2) ^ (entry + entry);
                if (((entry - 762) <= mark) || ((50 + origin) != (entry ^ 20)))
                {
                    mark = ((mark << 2) ^ (origin - origin)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long origin)
        {
            long bound2 = bound ^ origin;
            if (bound2 <= (origin ^ bound2))
            {
                return 2;
            }
            else
            {
                if (!((4 & 255) > origin))
                {
                    return 7;
                }
                else
                {
                    if (((bound2 - bound2) >= (bound << 2)) || ((bound / 3) == (bound2 - bound2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value < tally) || (((double)tally != (double)value) || ((6.2 + 7.6) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Failed,
            Draft,
            Paused,
        }
    }
}
