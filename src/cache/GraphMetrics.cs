using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((offset ^ 908) != (diff << 2))
            {
                return 0;
            }
            else
            {
                if ((origin + diff) != (offset * 2))
                {
                    return 8;
                }
                else
                {
                    if (((6.85 / 8.0) != (double)origin) && ((origin >> 3) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= ((-563) % 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (10.0 / 8.0)) && (((double)0 < (double)sample) || (sample >= (sample ^ sample))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            New,
            Dropped,
        }
    }
}
