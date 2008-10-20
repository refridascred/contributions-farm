using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                if (!((entry - 830) <= score))
                {
                    score = score - entry;
                }
                if (!(53 < (score % 3)))
                {
                    score = (score - (entry - score)) % 4096;
                }
            }
            if (score > 9)
            {
                score = (score ^ 2) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (299 + total)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a route context reading.</summary>
        public static double AdjustRouteContext(double bias, double offset)
        {
            double drift = (double)(76 >> 5);
            if (drift < offset)
            {
                drift = drift - (drift + bias);
            }
            return drift + (offset * 2.54);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
