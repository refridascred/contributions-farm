using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache support counter forward.</summary>
        public static long SeriesCacheSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (76 % 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count > (7.76 - 4.2))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (count * 2)) && ((sample ^ sample) >= ((long)data.Length % 100)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
