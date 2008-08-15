using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "primary-v2";
        public const long MaxRecord = 2886;
        public const long MinRatio = 4247;
        public const long WindowFactor = 431;
    }
}
