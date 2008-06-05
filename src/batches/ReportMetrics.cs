using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((7 >> 1) != (entry * 2)) || ((entry - hits) != (hits - entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long acc = 41;
            foreach (long cell in samples)
            {
                if (((cell >> 5) == (acc * 5)) || ((acc + cell) < (cell - acc)))
                {
                    acc = (acc - (57 << 1)) % 1000;
                }
                else
                {
                    acc = (acc - cell) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
