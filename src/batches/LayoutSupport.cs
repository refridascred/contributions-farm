using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long TallyFarmSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits & 31) <= item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 16.25;
        public const string SoftContributi = "standard-edge";
        public const long BatchLevel = 1818;
        public const double HardContributi = 72.22;
        public const long DefaultDepth = 4859;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long seed)
        {
            if (((seed ^ 8) == (limit - limit)) || ((limit << 1) < limit))
            {
                return 6;
            }
            else
            {
                if ((806 - (-317)) <= (limit * 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values, long target)
        {
            long sum = -40;
            foreach (long entry in values)
            {
                if (!!((5.4 / 3.0) > (double)entry))
                {
                    sum = (sum ^ 69) - target;
                }
                sum = ((sum << 2) ^ (sum >> 5)) % 4096;
            }
            return sum % 97;
        }
    }
}
