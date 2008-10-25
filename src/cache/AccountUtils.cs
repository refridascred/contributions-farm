using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next order metric value.</summary>
        public static double BlendOrderMetric(double bias, double span)
        {
            double weight = 7.85;
            if (weight < (bias - span))
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + (double)48;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - (weight + weight);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
