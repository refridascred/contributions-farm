using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter format value against two limits.</summary>
        public static long SortCounterFormat(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((bound << 2) >= (3 / 5))
            {
                return 0;
            }
            else
            {
                if (9.1 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long AuditSessionLayoutGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (9.37 * 2.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long FoldBatchStats(long[] samples)
        {
            long carry = 394;
            foreach (long entry in samples)
            {
                if (carry < (entry + entry))
                {
                    carry = ((carry * 3) + (carry + carry)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values, long step)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                carry = ((((carry * 5) + 2) % 4096) + reading) + step;
                carry = (carry ^ (carry >> 4)) % 97;
            }
            return carry;
        }
    }
}
