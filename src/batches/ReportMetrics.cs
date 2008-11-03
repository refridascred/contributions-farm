using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long mix = 15;
            foreach (long value in series)
            {
                if ((mix - value) < (value >> 2))
                {
                    mix = (mix ^ 960) % 1000;
                }
                mix = ((mix << 3) ^ (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                acc = (acc ^ (792 & 255)) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
