using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Done,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long sum = 44;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum + sum) ^ (long)i;
                }
                sum = ((sum * 3) + (value + 996)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) <= 67)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
