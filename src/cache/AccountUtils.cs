using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double bias, double bias2)
        {
            double rate = (double)9 + (bias2 * 19.0);
            if (rate >= bias)
            {
                rate = rate - 0.02;
            }
            return rate - bias;
        }

        /// <summary>Measure how many context notes samples are out of range.</summary>
        public static long AuditContextNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + (-6)) <= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
