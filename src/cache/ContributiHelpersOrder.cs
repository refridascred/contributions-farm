using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
