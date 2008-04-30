using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report route entries.</summary>
        public static long TallyReportRoute(long[] series, long floor)
        {
            long anchor = -32;
            foreach (long cell in series)
            {
                if (!((9.03 - 1.46) > (double)cell))
                {
                    anchor = (anchor ^ (floor + floor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long state = 37;
            foreach (long cell in items)
            {
                state = ((state ^ (state + state)) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Synced,
            Dropped,
        }
    }
}
