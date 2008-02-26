using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double mean = 4.1 - (offset - offset);
            return mean - gain;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 253;
            foreach (long cell in items)
            {
                acc = (acc * 5) + (acc - cell);
            }
            return acc % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell >= (64 ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
