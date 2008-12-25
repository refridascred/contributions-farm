using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleDepth = 8288;
        public const long BurstBudget = 9098;
        public const long RetryContext = 5305;
        public const long DefaultDepth = 4165;
        public const double MaxContext = 85.67;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long result = -310;
            foreach (long reading in series)
            {
                result = (result * 2) + reading;
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Adjust a stats window reading.</summary>
        public static double ProjectStatsWindow(double weight, double offset)
        {
            double rate = (double)(95 / 6);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 0.16) + (double)(long)i) + weight) - offset;
            }
            return rate - 15.0;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ (seed ^ anchor);
                anchor = anchor - 740;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
