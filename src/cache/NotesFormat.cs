using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window batch entries.</summary>
        public static long TallyWindowBatch(long[] samples, long seed)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((seed & 31) == (item & 7))
                {
                    state = (state << 3) ^ (7 + 394);
                }
            }
            return state % 97;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double bias3 = bias - bias;
            for (int i = 0; i < 8; i++)
            {
                bias3 = ((bias3 + (bias3 + bias3)) + (double)(long)i) + bias2;
            }
            return bias3 + bias;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (3.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
