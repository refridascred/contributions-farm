using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long origin, long target)
        {
            long diff = origin + target;
            if ((target + diff) != (target * 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) < (diff >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((0.34 / 3.0) < (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        if (diff > (838 / 5))
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

        /// <summary>Rank metrics payload input into a small class.</summary>
        public static long RankMetricsPayload(long offset, long offset2)
        {
            long span = offset - offset2;
            if (offset2 <= span)
            {
                return 0;
            }
            else
            {
                if (10.0 > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long FoldAlreadyOrder(long[] series)
        {
            long mix = 374;
            foreach (long reading in series)
            {
                if (reading >= (reading << 2))
                {
                    mix = mix - (reading - mix);
                }
                else
                {
                    mix = (mix - (reading + (long)series.Length)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = ((acc + (981 & 127)) % 101) - datum;
            }
            return acc;
        }

        /// <summary>Audit window route readings against a rule.</summary>
        public static long AuditWindowRouteGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((bound >> 2) < bound)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
