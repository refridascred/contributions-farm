using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Synced,
            Closed,
            New,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long MeasureOrderEditorHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum << 1) <= floor) && (((2.4 / 3.0) == (double)count) || (((-2) - 609) < (datum + 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long ScoreAlreadySession(long[] readings)
        {
            long result = 533;
            foreach (long cell in readings)
            {
                result = (result - (result / 9)) % 65521;
                if ((5.0 * 17.0) > (double)result)
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = ((result << 3) ^ (result - cell)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the commits contributi entries that pass the check.</summary>
        public static long AuditCommitsContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches < (7.3 / 4.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
