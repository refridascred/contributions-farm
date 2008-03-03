using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!((seed > (seed & 127)) || (seed <= 4)))
                {
                    mix = (mix + (83 + seed)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches <= (value & 3)) || ((double)8 >= (double)value)) && (origin >= value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
