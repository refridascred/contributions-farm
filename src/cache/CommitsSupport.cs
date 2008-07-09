using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long TallyEntryFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.9 < (double)cell) && (hits <= (hits - cell)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 1079;
        public const string BaseTimeout = "primary";
        public const long LimitEntry = 9339;
        public const long WindowCount = 6568;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long TallyWindowContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((6.7 + 9.5) == (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of checks already readings.</summary>
        public static long PairChecksAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
