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

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double span)
        {
            double weight = (double)(1 % 8);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - (double)9) - (double)(long)i) - span;
            }
            return weight + (rate / 3.0);
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
