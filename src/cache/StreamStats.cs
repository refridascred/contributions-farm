using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a githubfarm account figure with a bias.</summary>
        public static double SmoothGithubfarmAccount(double bias, double bias2)
        {
            double drift = bias / 8.0;
            if (drift <= (double)(-228))
            {
                drift = drift + (double)0;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (bias2 + bias2);
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
