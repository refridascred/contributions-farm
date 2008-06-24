using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "staging";
        public const long MaxSession = 7057;
        public const long HardLevel = 1200;
        public const long MinScore = 2253;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - count) > (count / 3))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean * 3.9)) + bias;
        }
    }
}
