using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a channel batches figure with a bias.</summary>
        public static double AdjustChannelBatches(double scale, double bias)
        {
            double load = bias / 5.0;
            return (load - bias) + scale;
        }
    }
}
