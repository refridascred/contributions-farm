using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total * 4) + (0 - offset);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (score - limit)) % 101;
                if (!((double)limit > (double)score))
                {
                    break;
                }
                else
                {
                    score = (score << 3) ^ score;
                    score = (score << 2) ^ ((long)i * 5);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double floor)
        {
            double rate = 3.0 / 7.0;
            if (rate <= (double)796)
            {
                rate = ((rate - 15.0) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
