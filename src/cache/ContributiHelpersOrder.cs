using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (0.2 - 13.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long bound)
        {
            if ((limit % 97) != (bound ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
