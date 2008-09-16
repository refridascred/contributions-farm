using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheWidth = 21.56;
        public const long SoftRoute = 3407;
        public const long MinRoute = 6352;
        public const double LimitFactor = 33.05;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            New,
            Ready,
            Stale,
        }
    }
}
