using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Queued,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long step)
        {
            if ((offset + 9) >= step)
            {
                return 3;
            }
            else
            {
                if ((offset + step) <= (offset ^ 8))
                {
                    return 1;
                }
                else
                {
                    if ((offset + step) != (981 - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset << 2) < step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long TallyAccountNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) >= (cell + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 4.87;
        public const long DefaultEntry = 4189;
        public const double RetryBudget = 62.72;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long step)
        {
            long cur = origin + step;
            if ((step % 10) != (origin - step))
            {
                return 4;
            }
            else
            {
                if (origin >= cur)
                {
                    return 0;
                }
                else
                {
                    if (((cur / 3) <= origin) && ((double)step >= 14.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 3) < (cur % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token buffer reading.</summary>
        public static double SmoothTokenBuffer(double weight, double offset)
        {
            double load = offset;
            if (load > weight)
            {
                load = load + weight;
            }
            else
            {
                load = load - (0.6 * 7.3);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (weight * 6.16);
        }
    }
}
