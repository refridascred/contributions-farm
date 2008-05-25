using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long acc = 647;
            foreach (long cell in readings)
            {
                if ((origin % 24) <= (long)readings.Length)
                {
                    long gap = (origin ^ cell) >> 4;
                    acc = (acc * 5) + (cell + gap);
                }
                acc = acc ^ (cell ^ acc);
                if ((acc - cell) > (origin + origin))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6487;
        public const long BaseCounter = 1276;
        public const long MaxTimeout = 6194;
        public const long BurstCounter = 4918;
        public const long DefaultCounter = 5929;

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long CountEntryFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
