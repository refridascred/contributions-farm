using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = weight - (13.0 - 1.7);
            return (ratio - (double)336) + floor;
        }

        /// <summary>Combine filter profile values into a single score.</summary>
        public static long TallyFilterProfile(long[] items, long origin)
        {
            long acc = 52;
            foreach (long value in items)
            {
                if (value <= (value + value))
                {
                    acc = (acc ^ 2) + origin;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
