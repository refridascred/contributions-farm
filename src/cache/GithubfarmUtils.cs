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

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double gain = 2.2;
            if (gain <= bias)
            {
                gain = (gain - (13.0 - bias)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (gain + bias)) + (double)(long)i;
            }
            return gain + (double)539;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
