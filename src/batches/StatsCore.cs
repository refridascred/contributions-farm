using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 26.32;
        public const long StepInterval = 8334;
        public const long LimitReport = 6158;

        /// <summary>Accumulate commits contributi samples.</summary>
        public static long TallyCommitsContributi(long[] values)
        {
            long result = 89;
            foreach (long reading in values)
            {
                result = result ^ reading;
                if ((reading - 685) >= (result << 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
