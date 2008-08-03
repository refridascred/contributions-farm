using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell % 12) <= (53 / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long SeriesAccountEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - ((long)i2 & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of window batch entries.</summary>
        public static long ScoreWindowBatch(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((((long)levels.Length % 24) >= (value - sum)) || ((14.0 + 6.07) < (double)value))
                {
                    sum = ((sum * 4) + sum) % 97;
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ (sum + 71)) % 97;
            }
            return sum % 1000;
        }
    }
}
