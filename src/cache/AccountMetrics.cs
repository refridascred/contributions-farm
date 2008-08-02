using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate route graph readings against a bound.</summary>
        public static bool GuardRouteGraphLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((0.61 + 6.26) <= (double)sample) || ((double)sample < (12.0 - 8.6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)origin >= (9.0 + 4.6))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples, long bound)
        {
            long sum = 999;
            foreach (long item in samples)
            {
                if ((double)item < 7.71)
                {
                    sum = (sum ^ (bound + bound)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 1)) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
