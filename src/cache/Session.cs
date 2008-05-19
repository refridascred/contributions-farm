using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long offset)
        {
            if ((offset + bound) <= bound)
            {
                return 3;
            }
            else
            {
                if (offset > bound)
                {
                    return 4;
                }
                else
                {
                    if (((offset * 5) >= (bound * 3)) || ((offset + offset) >= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long score = 270;
            foreach (long item in items)
            {
                if (score < 5)
                {
                    score = (((score << 2) ^ score) % 255) + item;
                }
                if ((double)(long)items.Length < (double)91)
                {
                    score = score - (step * 5);
                }
            }
            return score;
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (((anchor - (57 & 63)) % 97) + item) + step;
            }
            return anchor % 65521;
        }
    }
}
