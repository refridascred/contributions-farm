using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many session payload samples are out of range.</summary>
        public static long MeasureSessionPayloadMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (16.0 + 5.91))
                {
                    hits = ((hits + 3) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double mean = (offset - offset) - (7.87 / 4.0);
            return mean - ratio;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if (cell < (carry + cell))
                {
                    carry = (carry - 3) % 65521;
                }
            }
            if (carry < 429)
            {
                carry = ((carry << 2) ^ (carry % 60)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 18.1;
        public const long StepFormat = 927;
        public const string HardRatio = "alpha-1";
        public const string BatchFormat = "alpha";
    }
}
