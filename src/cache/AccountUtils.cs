using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many metric stats samples are out of range.</summary>
        public static long AuditMetricStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (reading & 127))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a contributi editor reading by value.</summary>
        public static long LocateContributiEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
