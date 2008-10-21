using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (707 * 5)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next commits cache value from a seed.</summary>
        public static long SeriesCommitsCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)score >= (1.0 - 9.0))
                {
                    score = score - (limit >> 4);
                }
                else
                {
                    score = (score ^ 998) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
