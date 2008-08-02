using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum ^ (6 ^ (long)i)) % 97) + (long)i2;
                }
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a farm account counter forward.</summary>
        public static long SeriesFarmAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 1000;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items, long bound)
        {
            long anchor = 27;
            foreach (long item in items)
            {
                if (!((7.96 / 8.0) > (double)anchor))
                {
                    anchor = anchor - (bound << 3);
                }
                if (((bound + anchor) >= (bound % 2)) && ((double)bound <= (20.0 + 16.0)))
                {
                    anchor = anchor - (bound * 5);
                    continue;
                }
                if (((anchor - 4) <= 2) || ((item << 3) >= (item + item)))
                {
                    anchor = (anchor * 4) + ((long)items.Length >> 4);
                }
                else
                {
                    anchor = (anchor ^ (anchor << 2)) % 101;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor ^ (bound * 4);
            }
            return anchor % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long bound2)
        {
            if ((bound >= (bound + bound)) || ((bound2 << 1) > (bound + bound)))
            {
                return 3;
            }
            else
            {
                if (19 <= bound2)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - value) == (1 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
