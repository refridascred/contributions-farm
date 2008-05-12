using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the cluster session series from a seed.</summary>
        public static long StepClusterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((acc - (long)i) <= origin)
                {
                    acc = (acc - (acc ^ origin)) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((305 >> 1) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }
    }
}
