using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally + tally) <= (entry + 7)) && (((tally >> 2) == (tally & 1)) && (2 <= tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double mean = (double)5 * 5.86;
            if (mean <= gain)
            {
                mean = (mean + (19.0 - mean)) - offset;
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback-edge";
        public const long BaseChecks = 1180;
        public const string WindowChecks = "open-1";
        public const double SoftChecks = 49.4;
        public const long CacheChecks = 8789;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double bias = (offset - 10.0) * 7.1;
            return bias + (offset - scale);
        }
    }
}
