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

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels)
        {
            long anchor = 953;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ cell) % 65521;
                if ((7.0 - 5.8) <= (double)anchor)
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
            }
            if (anchor > 81)
            {
                anchor = ((anchor << 3) ^ (anchor & 3)) % 65521;
            }
            return anchor % 1000;
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
