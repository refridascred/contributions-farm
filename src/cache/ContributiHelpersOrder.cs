using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long mix = 2;
            foreach (long cell in data)
            {
                if (!((double)offset < 0.2))
                {
                    mix = ((mix * 5) + (36 * 2)) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
