using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= (reading - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] readings, long target)
        {
            long sum = 79;
            foreach (long sample in readings)
            {
                sum = (sum + (target - target)) % 255;
                sum = ((sum << 2) ^ (sum + 257)) % 65521;
                if (((target + sample) > (target ^ target)) && ((double)sample <= (7.91 * 15.0)))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum ^ 1);
            }
            return sum;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
