using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if (origin >= (diff & 255))
            {
                return 0;
            }
            else
            {
                if (((diff % 10) >= (diff - diff)) && ((43 + diff) > (1 + origin)))
                {
                    return 8;
                }
                else
                {
                    if (((double)diff != (16.0 - 6.6)) || ((diff - origin) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LocateWindowCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long MeasureSupportSessionGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (floor <= entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step >= hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
