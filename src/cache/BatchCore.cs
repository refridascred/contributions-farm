using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((target / 5) == (sum ^ sum))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                    break;
                }
                if (sum > (item & 31))
                {
                    sum = sum - (-50);
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean - offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset + 2.0)) - (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Digest a series of entry githubfarm entries.</summary>
        public static long FoldEntryGithubfarm(long[] levels, long seed)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = (((state + (state - state)) % 1000) + datum) - seed;
            }
            return state;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long step, long limit)
        {
            if (((double)limit <= (6.65 + 3.8)) || ((double)step < 7.82))
            {
                return 7;
            }
            else
            {
                if ((step >> 1) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (step > (-21))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3 + 182) >= (limit / 2)) || (limit <= 55))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
