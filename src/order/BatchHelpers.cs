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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((934 << 1) != (reading % 100))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
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
