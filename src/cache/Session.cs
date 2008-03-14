using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long acc = 73;
            foreach (long entry in values)
            {
                if ((entry % 8) != (target + entry))
                {
                    acc = (acc + (target + acc)) % 1000;
                }
                if ((4.54 / 6.0) <= (double)entry)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((limit >> 1) >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (0.09 - 1.0))
                {
                    return 0;
                }
                else
                {
                    if ((offset + 5) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit checks filter readings against a rule.</summary>
        public static long CountChecksFilterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
