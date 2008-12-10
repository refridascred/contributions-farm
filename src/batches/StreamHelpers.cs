using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            if (bound >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit * 2) <= (bound ^ 27))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item == (5.26 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 73.68;
        public const long BatchDepth = 6732;
        public const double MinTools = 3.03;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long MatchClusterRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
