using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long state = 243;
            foreach (long cell in items)
            {
                state = (state ^ cell) % 97;
                if (cell > (state + 9))
                {
                    break;
                }
            }
            if (state > 42)
            {
                state = (state - state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double rate = (double)530 / 3.0;
            return (rate + (offset * 6.3)) + gain;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
