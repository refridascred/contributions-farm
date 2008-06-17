using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ 7) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 3293;
        public const double DefaultSpan = 24.02;
        public const long WindowWidth = 5647;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (9.46 * 5.58))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
