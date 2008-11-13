using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardBudget = "fallback-v2";
        public const string SoftStream = "stable-1";
        public const double WindowStream = 22.31;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value ^ value) <= (174 * 4)) || (((7.06 + 6.1) != (double)value) && ((2 + 20) > (value >> 5))))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long AuditChannelRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 1) >= tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double mean = (double)(34 % 60);
            return ((mean - 9.59) + bias) + span;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
