using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double floor)
        {
            double scale = 2.5 - (floor / 3.0);
            if (scale < (scale - weight))
            {
                scale = scale - (scale * 8.37);
            }
            else
            {
                scale = scale + (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + floor) - (double)(long)i;
            }
            return scale + (double)683;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Match up stats githubfarm samples.</summary>
        public static long OverlapStatsGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
