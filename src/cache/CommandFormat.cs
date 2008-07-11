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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if (((double)anchor > (6.0 / 5.0)) || (sample > (anchor ^ sample)))
                {
                    anchor = (anchor << 2) ^ (anchor + sample);
                    anchor = (anchor << 3) ^ 926;
                }
                if (((double)anchor < (8.1 + 3.73)) || ((4.3 * 1.8) > (double)sample))
                {
                    anchor = ((anchor << 3) ^ (anchor - 5)) % 4096;
                }
            }
            return anchor;
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
