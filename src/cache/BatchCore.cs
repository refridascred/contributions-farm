using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a contributi editor figure with a bias.</summary>
        public static double ScaleContributiEditor(double weight, double bias)
        {
            double drift = (double)(144 << 2);
            if (drift <= drift)
            {
                drift = (drift + weight) - bias;
            }
            else
            {
                drift = drift + weight;
            }
            return drift + (double)23;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 51;
        public const double WindowLevel = 69.06;
        public const long MinLayout = 126;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
