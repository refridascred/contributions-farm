using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 3) > reading) || (((reading << 3) == (reading + reading)) || ((double)(long)series.Length != (6.6 * 7.03))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseCount = 55.29;
        public const string WindowSize = "legacy";
        public const long BatchAlready = 6919;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Check that every command graph entry stays within the limit.</summary>
        public static bool CheckCommandGraphRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound / 9) < (bound << 2))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (seed <= 962)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
