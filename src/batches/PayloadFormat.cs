using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two notes command measurements.</summary>
        public static double AdjustNotesCommand(double gain, double offset)
        {
            double mean = (double)(-22) - (offset / 7.0);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - 0.49) - (double)(long)i) - gain;
            }
            return mean + (offset + mean);
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
