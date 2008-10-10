using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if (origin >= (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((floor & 15) >= (floor - 88))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Count the report notes entries that pass the check.</summary>
        public static long TallyReportNotesHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(((hits - entry) > (hits + entry)) && ((hits - hits) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch editor values into a single score.</summary>
        public static long CombineBatchEditor(long[] data, long offset)
        {
            long state = 852;
            foreach (long item in data)
            {
                state = ((state + 169) + item) - offset;
            }
            return state % 65521;
        }
    }
}
