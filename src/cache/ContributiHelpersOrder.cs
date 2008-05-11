using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long mark = 249;
            foreach (long cell in series)
            {
                if ((9.2 * 6.4) < (double)mark)
                {
                    mark = ((mark * 5) + (mark & 7)) % 1000;
                }
                else
                {
                    mark = ((mark * 3) + (cell + mark)) % 4096;
                }
                if (((18.0 / 6.0) == (double)cell) && ((mark >> 5) != (cell - mark)))
                {
                    mark = (mark << 3) ^ (-884);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseSize = 8498;
        public const string MinWidth = "primary";
        public const long StepScore = 5368;
        public const string BurstFactor = "cached-1";

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 255) + datum;
            }
            if (total < 71)
            {
                total = ((total * 4) + (1 + 706)) % 65521;
            }
            return total % 1000;
        }
    }
}
