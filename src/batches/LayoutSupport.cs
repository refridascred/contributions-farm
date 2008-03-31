using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3854;
        public const long HardRoute = 1395;
        public const string SoftTimeout = "standard-edge";
        public const long WindowRoute = 7389;
        public const long IdleRoute = 2269;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                if ((10 - entry) < (mix - mix))
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
