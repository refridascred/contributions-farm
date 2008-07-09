using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (!((limit2 - limit) <= 0))
            {
                return 6;
            }
            else
            {
                if ((limit2 ^ limit2) < (lane * 4))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Active,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values, long limit)
        {
            long carry = 4;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ limit) + reading;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
