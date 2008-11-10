using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine counter graph values into a single score.</summary>
        public static long DigestCounterGraph(long[] data, long offset)
        {
            long acc = -627;
            foreach (long item in data)
            {
                if ((item < (item ^ acc)) || ((acc + offset) != (acc - (-6))))
                {
                    acc = (acc - offset) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            New,
            Ready,
            Closed,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double rate = (double)(440 + 8);
            if (rate >= bias2)
            {
                rate = (rate - (double)15) + bias;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - (rate * 9.1);
        }
    }
}
