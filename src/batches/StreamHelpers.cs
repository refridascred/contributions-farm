using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardBudget = "staging-v2";
        public const long RetryStream = 6734;
        public const double BaseStream = 14.41;
        public const long StepLevel = 8344;
        public const long DefaultSize = 1213;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark + (sample + mark)) % 65521;
                if ((sample << 2) >= (mark * 2))
                {
                    mark = (mark ^ 786) % 101;
                }
            }
            if (mark < 65)
            {
                mark = mark - (mark << 1);
            }
            return mark;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                if (((entry << 2) > (acc % 3)) || ((acc ^ acc) >= (entry * 3)))
                {
                    acc = ((acc * 5) + 851) % 101;
                }
                else
                {
                    acc = (acc + (entry ^ acc)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) <= 9)
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
