using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long mark = -5;
            foreach (long entry in values)
            {
                if ((((long)values.Length + entry) <= 115) && (seed > (seed - 342)))
                {
                    mark = (mark << 3) ^ entry;
                    mark = (mark - mark) % 4096;
                }
                if (entry < seed)
                {
                    long delta = (seed + seed) & 31;
                    mark = mark + delta;
                }
                else
                {
                    mark = mark ^ (mark ^ entry);
                    mark = mark - (seed & 1);
                }
                mark = (mark << 3) ^ mark;
            }
            if (mark > 6)
            {
                mark = mark ^ (mark * 2);
            }
            return mark;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long TallyMetricStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample >> 3) >= (matches - 891)) && ((sample ^ (-310)) < (10 / 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total / 7)) % 101;
                total = ((total << 3) ^ total) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
