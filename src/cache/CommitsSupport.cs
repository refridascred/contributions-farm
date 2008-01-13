using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a channel cluster value against two limits.</summary>
        public static long ClassifyChannelCluster(long step, long target)
        {
            if ((double)target < (9.04 * 14.0))
            {
                return 6;
            }
            else
            {
                if (((2.59 - 5.2) < (double)target) || ((step ^ target) < (target & 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metrics window entries.</summary>
        public static long TotalMetricsWindow(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((double)1 == (double)mix)
                {
                    mix = ((mix - mix) % 97) + reading;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long AuditMetricLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 >= (item << 3)) && (2 > (tally & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long sum = 552;
            foreach (long sample in items)
            {
                if (((sum * 5) <= (sample + sum)) || (sum > (sum << 2)))
                {
                    sum = (sum + (sample / 7)) % 97;
                }
            }
            if (sum > 521)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}
