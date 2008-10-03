using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc + (target + target)) % 1000) - (long)i2;
                }
                acc = (acc ^ ((long)i - acc)) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of window session readings.</summary>
        public static long MatchWindowSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Synced,
            Locked,
            Stale,
        }
    }
}
