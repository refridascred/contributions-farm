using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((double)cell < 7.3) || !((double)hits > (7.5 + 1.01)))
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long anchor = 73;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (anchor - cell)) % 97;
                if ((cell % 7) >= cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = (double)8 / 6.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - rate) + (double)(long)i) + bias;
            }
            return scale - 7.08;
        }
    }
}
