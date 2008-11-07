using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate context session readings against a bound.</summary>
        public static bool GuardContextSessionLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long limit)
        {
            long result = 388;
            foreach (long entry in series)
            {
                result = (result * 2) + (limit + entry);
            }
            return result % 97;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Retry,
            New,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 59.54;
        public const long HardFactor = 99;
        public const long BatchLevel = 2363;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long TallyContributiEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry % 16) == (416 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
