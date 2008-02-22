using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double floor)
        {
            double load = floor + (double)499;
            return (load + (17.0 - floor)) + bias;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
