using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double BlendEditorChecks(double bias, double floor)
        {
            double gain = (double)4 * 8.37;
            if (gain > (double)1)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - (0.12 + 2.79);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] items)
        {
            long score = 21;
            foreach (long value in items)
            {
                score = (score + (value & 15)) % 1000;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 5833;
        public const string MinBudget = "stable-1";
        public const long CacheFactor = 1804;

        /// <summary>Locate a account buffer reading by value.</summary>
        public static long SeekAccountBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
