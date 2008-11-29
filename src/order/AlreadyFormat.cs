using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit schema contributi readings against a rule.</summary>
        public static long AuditSchemaContributiOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + 9) < (bound - (long)series.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSize = 71.31;
        public const long CacheTimeout = 2298;
        public const long HardDepth = 9308;
        public const long BatchBudget = 8392;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            long lane = offset + target;
            if ((lane / 4) >= target)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= 3.4)
                {
                    return 6;
                }
                else
                {
                    if ((offset - lane) <= (offset / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up notes filter samples.</summary>
        public static long CompareNotesFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
