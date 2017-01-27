using System;

namespace Common.Utilities
{
    /// <summary>Report stats helpers.</summary>
    public static class ReportStats
    {
        /// <summary>Clamp a contributi value to a valid range.</summary>
        public static double ClampContributi(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Clamp a editor commits value to a valid range.</summary>
        public static double ClampEditorCommits(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Average a list of metric samples.</summary>
        public static double AverageMetric(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Express a command count as a percentage.</summary>
        public static double CommandPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Interpolate between two contributi account values.</summary>
        public static double LerpContributiAccount(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
