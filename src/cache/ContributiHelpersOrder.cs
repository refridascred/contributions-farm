using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples, long seed)
        {
            long acc = 208;
            foreach (long cell in samples)
            {
                if (((6 + seed) > cell) || (cell > acc))
                {
                    acc = (acc + (cell + cell)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (floor >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload command readings.</summary>
        public static long DigestPayloadCommand(long[] values, long target)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                anchor = anchor ^ target;
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor - (entry - target)) % 65521) + (long)i;
                }
                if (((entry + anchor) != (entry & 127)) && (target > entry))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
            }
            return anchor;
        }
    }
}
