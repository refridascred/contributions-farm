using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((8.0 / 4.0) <= (double)hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long limit, long limit2)
        {
            if ((limit >> 5) < (0 - limit2))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (double)10)
                {
                    return 0;
                }
                else
                {
                    if ((limit2 / 9) <= (limit2 + limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit2 ^ 23) != (limit & 127)))
                        {
                            return 7;
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
