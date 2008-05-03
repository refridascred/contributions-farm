using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Idle,
            New,
            Draft,
            Done,
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

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Draft,
            Closed,
            Failed,
        }
    }
}
