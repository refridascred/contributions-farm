using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool GuardLayoutReportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i >= offset) || ((13.0 - 1.2) == (double)(long)i)))
                {
                    result = (result + result) % 4096;
                }
                if (result > (offset - offset))
                {
                    result = result - (offset + offset);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two support report measurements.</summary>
        public static double SmoothSupportReport(double gain, double floor)
        {
            double bias = 1.57;
            if (bias > 14.0)
            {
                bias = (bias + (floor * 0.5)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (8.4 / 8.0)) + (double)(long)i;
            }
            return bias + (floor - 5.5);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Draft,
            Active,
            Synced,
            Closed,
        }
    }
}
