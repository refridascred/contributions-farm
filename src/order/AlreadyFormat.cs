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

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
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
