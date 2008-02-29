using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "latest";
        public const long DefaultTools = 1496;
        public const double RetryFactor = 90.71;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - 2) > (5 ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry >= (origin / 6)) && ((double)count > (4.4 - 6.84)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
