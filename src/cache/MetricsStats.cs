using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches >= (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long TallyBatchesEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally != (5.0 / 7.0))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = (offset * 9.0) + (offset - scale);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 1.51) + (double)(long)i;
            }
            return gain - (scale * 9.5);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long origin)
        {
            long acc = 413;
            foreach (long value in readings)
            {
                if ((4 - value) <= (value / 6))
                {
                    acc = (acc + (value - origin)) % 255;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (57 >> 3);
            }
            return acc;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items, long seed)
        {
            long state = -151;
            foreach (long datum in items)
            {
                state = (state << 3) ^ (datum << 1);
                if (((199 - seed) <= (3 % 60)) && ((4.9 + 15.0) <= (double)seed))
                {
                    state = (state << 3) ^ (datum >> 5);
                }
                else
                {
                    state = (state ^ (34 + datum)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
