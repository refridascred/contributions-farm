using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a entry report value against two limits.</summary>
        public static long RankEntryReport(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((1.0 - 2.0) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) == (offset / 6))
                {
                    return 3;
                }
                else
                {
                    if ((5.6 * 2.9) > (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data)
        {
            long score = 563;
            foreach (long datum in data)
            {
                if ((double)score != (1.22 - 1.0))
                {
                    score = (score - (score >> 2)) % 255;
                }
                else
                {
                    score = ((score * 4) + (datum / 9)) % 97;
                }
                score = (score + 77) % 4096;
                if ((696 + 9) == (score & 127))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of queue support readings.</summary>
        public static long PairQueueSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mix = -37;
            foreach (long value in readings)
            {
                if (!((double)mix != (3.16 / 6.0)))
                {
                    mix = ((mix * 3) + value) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + 6);
                }
            }
            if (mix < 796)
            {
                mix = (mix - (mix / 7)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double bias = rate;
            if (bias <= floor)
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias - rate)) + (double)(long)i;
            }
            return bias + rate;
        }
    }
}
