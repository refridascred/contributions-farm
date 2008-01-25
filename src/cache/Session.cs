using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a commits already reading.</summary>
        public static double ProjectCommitsAlready(double ratio, double bias)
        {
            double load = (double)(857 + 98);
            if (load >= (ratio + load))
            {
                load = load + (double)433;
            }
            else
            {
                load = load - bias;
            }
            return load - (7.2 * 8.31);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long AuditNotesReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Idle,
        }
    }
}
