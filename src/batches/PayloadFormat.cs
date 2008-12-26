using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (ratio / 7.0))
            {
                ratio = ratio - (offset / 6.0);
            }
            return ratio + (scale + offset);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series)
        {
            long total = 386;
            foreach (long sample in series)
            {
                total = (total - (sample & 127)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a support route counter forward.</summary>
        public static long IterateSupportRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + acc) < (acc * 2))
                {
                    acc = ((acc * 3) + ((long)i - acc)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
