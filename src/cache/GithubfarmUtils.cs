using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Synced,
            New,
            Queued,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ floor) % 4096;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span + 15.0)) + (double)(long)i;
            }
            return load - (ratio / 2.0);
        }
    }
}
