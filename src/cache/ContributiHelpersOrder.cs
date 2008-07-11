using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm notes samples.</summary>
        public static long CombineFarmNotes(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                total = (total ^ (item ^ 2)) % 65521;
                if ((19.0 / 8.0) != (double)item)
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total > 990)
            {
                total = ((total * 4) + (total & 31)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long CountGithubfarmAccountHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((72 & 31) > ((-11) + count))
                {
                    count = ((count + 1) - item) + limit;
                }
            }
            return count;
        }
    }
}
