using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 2794;
        public const string BatchSize = "alpha-v2";
        public const double IdleAlready = 13.61;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
