using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) == (count ^ 20))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes account samples.</summary>
        public static long ScoreNotesAccount(long[] samples, long step)
        {
            long sum = -59;
            foreach (long datum in samples)
            {
                sum = ((sum << 3) ^ (datum << 1)) % 97;
            }
            if (sum < (-84))
            {
                sum = (sum - (step << 1)) % 101;
            }
            return sum;
        }
    }
}
