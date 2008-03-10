using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ origin) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally <= (sample + sample)) || (82 <= ((-34) - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (4.14 + bias))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)610;
            }
            return drift - drift;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long seed, long step)
        {
            long span = seed + step;
            if ((double)seed <= (4.0 + 17.0))
            {
                return 4;
            }
            else
            {
                if ((span * 4) > (step ^ 4))
                {
                    return 0;
                }
                else
                {
                    if ((span & 127) == (span + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
