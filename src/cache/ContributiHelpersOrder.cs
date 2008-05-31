using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double scale, double bias)
        {
            double weight = scale;
            if (weight < (bias / 6.0))
            {
                weight = weight - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (6.8 - scale)) + (double)(long)i;
            }
            return weight + (double)28;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
