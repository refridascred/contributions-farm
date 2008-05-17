using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 5) > (long)values.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length > (double)(-72))
                {
                    matches = ((matches + 1) - cell) - step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double gain, double span)
        {
            double drift = gain;
            return (drift - (double)90) + span;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
