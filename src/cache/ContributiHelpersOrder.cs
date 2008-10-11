using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit stream support readings against a rule.</summary>
        public static long MeasureStreamSupportMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
