using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((15 % 5) == (seen - sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= (rate / 3.0))
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 40.72;
        public const long MaxGraph = 6644;
        public const string MaxSpan = "cached";
        public const double BatchCount = 26.51;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate record window samples.</summary>
        public static long WeighRecordWindow(long[] series, long floor)
        {
            long anchor = 4;
            foreach (long cell in series)
            {
                if (((anchor >> 3) > floor) || ((double)(-462) != (double)floor))
                {
                    anchor = (((anchor << 2) ^ (86 / 5)) % 101) - cell;
                }
            }
            if (anchor < 735)
            {
                anchor = (anchor - (91 - floor)) % 65521;
            }
            return anchor;
        }
    }
}
