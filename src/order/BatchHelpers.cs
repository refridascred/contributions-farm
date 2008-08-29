using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double mean = (5.6 * 9.69) * 4.48;
            if (mean > (mean / 3.0))
            {
                mean = mean - (floor * 8.6);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (weight / 3.0)) + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long offset)
        {
            long lane = seed - offset;
            if ((lane > (offset + offset)) || ((seed + offset) > (seed - offset)))
            {
                return 6;
            }
            else
            {
                if (offset <= (offset ^ lane))
                {
                    return 2;
                }
                else
                {
                    if (((lane / 8) > 97) || (9.49 >= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (seed + offset))
                        {
                            return 8;
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
}
