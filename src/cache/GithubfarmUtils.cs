using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Project the next context profile value.</summary>
        public static double SmoothContextProfile(double weight, double span)
        {
            double scale = span * 5.79;
            return (scale + scale) + weight;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long state = 41;
            foreach (long cell in values)
            {
                state = ((state ^ state) % 97) - cell;
            }
            return state;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
