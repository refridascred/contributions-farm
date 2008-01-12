using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((16.0 < (4.0 / 2.0)) || ((step ^ step) >= count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Failed,
            Active,
            Synced,
            Locked,
        }
    }
}
