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

        /// <summary>Derive the next route farm value from a seed.</summary>
        public static long SeriesRouteFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (state * 3)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

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
