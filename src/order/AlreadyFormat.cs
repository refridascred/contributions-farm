using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "open-1";
        public const long DefaultDepth = 4270;
        public const long BatchFarm = 8376;
        public const long LimitWidth = 2688;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 55.69;
        public const string WindowTimeout = "legacy-v2";
        public const long MaxScore = 4724;
        public const string BaseNotes = "open";

        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally / 8)) && !((sample + 617) >= (target % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result + (result + result);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
