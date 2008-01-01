using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (623 + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ (carry - reading)) % 4096) + (long)i;
                    carry = (carry * 5) + (reading - reading);
                }
                if ((carry < ((long)samples.Length - limit)) && ((double)carry != (double)reading))
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Queued,
            Synced,
            New,
        }
    }
}
