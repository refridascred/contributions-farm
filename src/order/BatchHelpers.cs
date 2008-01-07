using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ cell) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double weight = gain + (6.0 - floor);
            if (weight > (floor + weight))
            {
                weight = weight + 9.4;
            }
            else
            {
                weight = weight + (floor - weight);
            }
            return weight + (13.0 * 5.0);
        }
    }
}
