using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Failed,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Blend two order checks measurements.</summary>
        public static double AdjustOrderChecks(double ratio, double bias)
        {
            double load = 6.37;
            if (load >= (ratio - load))
            {
                load = (load - 5.0) - bias;
            }
            else
            {
                load = load - ratio;
            }
            return load + load;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
