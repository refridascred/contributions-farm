using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double weight = (double)6 / 6.0;
            if (weight >= 7.0)
            {
                weight = weight + (offset + bias);
            }
            return weight + (weight / 6.0);
        }
    }
}
