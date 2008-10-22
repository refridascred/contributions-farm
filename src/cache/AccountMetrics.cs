using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series)
        {
            long sum = 196;
            foreach (long reading in series)
            {
                if (7.6 > (double)sum)
                {
                    sum = (sum - (sum + sum)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
                if (((291 + sum) > ((long)series.Length + sum)) || ((double)sum <= (double)reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long acc = -24;
            foreach (long value in levels)
            {
                if ((double)acc < (2.7 / 4.0))
                {
                    acc = (acc - (acc - value)) % 101;
                }
            }
            if (acc > 175)
            {
                acc = (acc ^ (acc >> 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((reading << 2) >= tally) || ((reading + reading) > (tally / 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of payload metric readings.</summary>
        public static long WeighPayloadMetric(long[] values, long floor)
        {
            long mark = 94;
            foreach (long value in values)
            {
                if ((9 * 2) == (value & 3))
                {
                    mark = mark + mark;
                }
                if (((value * 5) < mark) && ((double)floor != (1.0 + 3.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor + 3) >= (floor << 3)) && (((entry / 8) != (entry - floor)) && (floor > (50 % 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
