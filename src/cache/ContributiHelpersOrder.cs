using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long origin)
        {
            long result = 519;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ (sample ^ sample)) % 1000) + origin;
            }
            return result;
        }

        /// <summary>Validate contributi buffer readings against a bound.</summary>
        public static bool VerifyContributiBufferLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
