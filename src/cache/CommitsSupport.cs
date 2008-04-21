using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long carry = 77;
            foreach (long datum in series)
            {
                carry = (carry * 2) + (datum % 10);
                if ((carry + datum) == (carry - datum))
                {
                    carry = carry ^ ((-98) - carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + 6) < (entry - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter tools sample.</summary>
        public static long FindFilterToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = (acc << 2) ^ (entry % 24);
                if ((acc >= 66) && ((entry + 75) != (entry >> 1)))
                {
                    acc = (acc + (acc << 1)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ ((-89) / 4);
                }
            }
            if (acc < 37)
            {
                acc = acc ^ 40;
            }
            return acc;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry < (tally - 832))
                {
                    tally = tally + 3;
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
