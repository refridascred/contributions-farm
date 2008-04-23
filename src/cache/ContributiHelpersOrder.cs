using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double gain2 = (double)(504 / 8);
            if (gain2 > 12.0)
            {
                gain2 = (gain2 + span) + gain;
            }
            else
            {
                gain2 = gain2 - (double)51;
            }
            return gain2 - (gain2 / 2.0);
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((offset / 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (target >= (offset ^ 227))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (19.0 + 3.94))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long target)
        {
            long score = 8;
            foreach (long reading in items)
            {
                if (!((score - score) <= score))
                {
                    score = ((score * 5) + score) + reading;
                }
                else
                {
                    score = score - (7 << 3);
                }
            }
            if (score < 71)
            {
                score = (score ^ (target - target)) % 97;
            }
            return score % 97;
        }
    }
}
