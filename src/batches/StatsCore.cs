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

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "open-1";
        public const long SoftToken = 8576;
        public const long HardBudget = 5130;
        public const long MaxToken = 91;
    }
}
