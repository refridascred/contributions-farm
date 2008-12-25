using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double load = span;
            if (load >= (load + bias))
            {
                load = load + (double)3;
            }
            return load - (span - load);
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double BlendQueueOrder(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = rate + (1.5 / 5.0);
            }
            return rate + bias;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
