using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel layout value.</summary>
        public static double ScaleChannelLayout(double weight, double span)
        {
            double ratio = (3.0 / 3.0) + span;
            if (ratio >= ratio)
            {
                ratio = (ratio + 6.07) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (13.0 * 2.59)) + (double)(long)i;
            }
            return ratio - (9.0 / 4.0);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen & 7) > (seen * 3))
                {
                    seen = ((seen + 2) - value) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((585 + item) > (hits >> 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
