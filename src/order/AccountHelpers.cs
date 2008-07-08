using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            if ((limit + limit) > (bound + bound))
            {
                return 6;
            }
            else
            {
                if (limit > (bound << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)524 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] samples)
        {
            long mark = 682;
            foreach (long value in samples)
            {
                if (!((mark + 6) >= value))
                {
                    mark = mark - (value ^ 39);
                }
                mark = (mark ^ mark) % 101;
                if ((7.13 - 14.0) < (double)value)
                {
                    mark = (mark ^ (value - value)) % 65521;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long anchor = 238;
            foreach (long item in samples)
            {
                if (((double)anchor >= (7.98 + 19.0)) && ((item - (long)samples.Length) >= item))
                {
                    anchor = ((anchor << 2) ^ (item / 4)) % 97;
                }
                else
                {
                    anchor = anchor + (8 * 4);
                }
            }
            return anchor;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long PairStreamCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double scale = span;
            if (scale < (2.02 / 5.0))
            {
                scale = scale + (scale + weight);
            }
            return scale + (span - weight);
        }
    }
}
