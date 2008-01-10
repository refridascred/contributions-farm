using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long score = -55;
            foreach (long value in levels)
            {
                if ((11.0 / 7.0) >= (double)value)
                {
                    score = ((score << 3) ^ (value - value)) + limit;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long limit)
        {
            if ((14.0 * 1.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit >> 4) != (81 ^ step))
                {
                    return 8;
                }
                else
                {
                    if (((51 % 10) >= (step + step)) && ((6.7 / 8.0) != (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double drift = (double)53 * 1.07;
            if (drift <= drift)
            {
                drift = (drift + (double)54) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
