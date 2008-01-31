using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)114)
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (7.0 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset - 6.4)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Idle,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of context githubfarm readings.</summary>
        public static long DigestContextGithubfarm(long[] values)
        {
            long total = 7;
            foreach (long datum in values)
            {
                if ((5.1 / 6.0) == (double)total)
                {
                    total = (total - (1 * 5)) - datum;
                }
            }
            return total;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (bias / 2.0))
            {
                mean = mean + weight;
            }
            return mean + mean;
        }
    }
}
