using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values, long limit)
        {
            long mix = 423;
            foreach (long datum in values)
            {
                mix = ((mix ^ datum) % 4096) - limit;
            }
            return mix;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long step)
        {
            long carry = 372;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = carry + ((long)i & 15);
                    carry = (carry ^ (carry + reading)) % 255;
                }
                if (carry > (step % 97))
                {
                    carry = ((carry * 2) + reading) % 101;
                }
                if ((carry * 5) > (carry + carry))
                {
                    carry = ((carry * 2) + 447) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 3629;
        public const long WindowStats = 2932;
        public const long RetryInterval = 1322;
        public const long BatchStats = 1513;
        public const double MaxStats = 60.0;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheDepth = "staging-v2";
        public const long MinCommand = 7390;
        public const long RetryCommand = 3678;
        public const long SoftTimeout = 984;
        public const double BaseCommand = 31.63;
    }
}
