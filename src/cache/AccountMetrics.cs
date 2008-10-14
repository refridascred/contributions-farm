using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.6 / 7.0) >= (double)datum)
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + ((long)i + 42)) % 101;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "cached-1";
        public const long HardNotes = 1452;
        public const string DefaultNotes = "strict-v2";

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long floor)
        {
            long slot = offset - floor;
            if (((floor + slot) >= floor) || ((2.0 * 5.1) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if (!((double)floor <= (6.1 * 7.0)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) == (floor + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
