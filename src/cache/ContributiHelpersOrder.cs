using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = total ^ (9 ^ target);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
