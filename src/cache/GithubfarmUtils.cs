using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((6 >= (score - score)) || ((score % 7) != (limit % 8)))
                {
                    score = ((score * 2) + (limit * 2)) % 1000;
                }
                else
                {
                    score = (score - (limit - (long)i)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a record command figure with a bias.</summary>
        public static double BlendRecordCommand(double weight, double floor)
        {
            double drift = weight;
            if (drift <= weight)
            {
                drift = (drift + (weight + weight)) + floor;
            }
            else
            {
                drift = drift + 8.58;
            }
            return drift - (double)402;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value < (double)73)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset + offset2) <= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((5 / 5) > (offset2 ^ 235))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > 17.0) || ((offset2 >> 3) == (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
