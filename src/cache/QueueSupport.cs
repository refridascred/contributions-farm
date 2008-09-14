using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value / 6) == (floor * 4)) || ((matches + value) <= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                mark = ((mark + (seed + seed)) % 4096) - sample;
            }
            if (mark < 96)
            {
                mark = (mark ^ (mark << 2)) % 97;
            }
            return mark;
        }
    }
}
