using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
