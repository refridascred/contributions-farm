using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            New,
            Idle,
            Locked,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long origin)
        {
            if ((origin < (origin & 127)) || (origin >= (75 & 255)))
            {
                return 0;
            }
            else
            {
                if ((0.6 * 18.0) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 1730;
        public const long MaxStream = 4306;
        public const long DefaultScore = 4724;
        public const long WindowDepth = 3476;
        public const double BurstTimeout = 51.33;
    }
}
