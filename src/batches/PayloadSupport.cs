using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = (rate - (rate / 3.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 10.0) + (double)(long)i;
            }
            return rate + (bias2 * 0.8);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
