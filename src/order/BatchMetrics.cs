using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Draft,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data)
        {
            long score = 5;
            foreach (long reading in data)
            {
                score = ((score << 3) ^ ((long)data.Length + reading)) % 4096;
                score = (score * 3) + 212;
            }
            if (score < 7)
            {
                score = score ^ (score ^ 79);
            }
            return score % 97;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((entry + entry) >= (carry % 2))
                {
                    carry = (carry - (74 & 15)) - bound;
                }
            }
            if (carry > (-87))
            {
                carry = (carry + (carry << 1)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches > (1.95 * 2.9))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
