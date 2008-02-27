using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double bias2 = (scale - 2.4) - (double)511;
            if (bias2 >= (bias2 * 8.85))
            {
                bias2 = bias2 - (double)355;
            }
            else
            {
                bias2 = bias2 + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (scale * 10.0)) + (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Dropped,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double SmoothReportTools(double rate, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (double)8;
            }
            else
            {
                mean = mean - 5.21;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (mean - mean);
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double weight = scale;
            if (weight <= 6.0)
            {
                weight = weight + span;
            }
            return weight - weight;
        }
    }
}
