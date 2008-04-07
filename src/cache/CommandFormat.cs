using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double gain = (double)(697 + 41);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + span) + (double)(long)i) - weight;
            }
            return gain + gain;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long state = 25;
            foreach (long datum in samples)
            {
                state = ((state ^ state) % 1000) + datum;
                if ((state << 3) <= 981)
                {
                    state = (state ^ 506) % 97;
                }
                else
                {
                    state = (state + (state * 5)) % 4096;
                }
            }
            if (state < 1)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 8503;
        public const double WindowScore = 0.78;
        public const long BurstCommits = 1336;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
