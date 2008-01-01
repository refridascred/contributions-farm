using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (50 <= (45 + reading))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if ((datum ^ mark) <= (datum + mark))
                {
                    mark = (mark + 8) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool ValidateChecksContextRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSize = 50.08;
        public const long LimitBatch = 6429;
        public const long SoftDepth = 1220;
        public const double HardTimeout = 82.45;
        public const long DefaultBatch = 6520;
    }
}
