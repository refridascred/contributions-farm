using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinFactor = 4991;
        public const long LimitBudget = 4636;
        public const long HardTools = 5531;
        public const double MinTools = 15.77;
        public const string RetryTools = "local";

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool VerifyStreamReportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
