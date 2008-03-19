using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double weight = (double)7 + bias;
            if (weight < bias)
            {
                weight = weight + (scale + 9.8);
            }
            return weight + (double)32;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long acc = 8;
            foreach (long reading in samples)
            {
                if (!((seed * 5) == (reading + seed)))
                {
                    acc = (acc + (seed + 840)) % 97;
                }
                else
                {
                    acc = (acc - 780) % 101;
                }
            }
            if (acc > 576)
            {
                acc = (acc + 495) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Closed,
            Locked,
            Failed,
            Draft,
        }
    }
}
