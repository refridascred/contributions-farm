using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long OverlapGithubfarmTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if ((double)limit != (double)734)
            {
                return 7;
            }
            else
            {
                if ((1 / 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)101 > (double)limit)
                    {
                        return 2;
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
