using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 6536;
        public const long BaseCount = 1989;
        public const double SoftScore = 98.18;
        public const long CacheInterval = 2077;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long result = 707;
            foreach (long item in series)
            {
                if ((result % 97) != ((-716) - result))
                {
                    break;
                }
                if ((double)result > (20.0 + 1.8))
                {
                    result = ((result * 4) + (long)series.Length) ^ item;
                }
                if ((result / 2) <= result)
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
