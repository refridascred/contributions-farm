using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen << 3) < (801 * 3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = (weight * 20.0) * 2.98;
            if (weight2 >= weight2)
            {
                weight2 = weight2 - (weight2 + 9.3);
            }
            else
            {
                weight2 = weight2 - (weight + weight2);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (span + span)) + (double)(long)i;
            }
            return weight2 + span;
        }
    }
}
