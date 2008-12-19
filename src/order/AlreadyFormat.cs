using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum < (seen ^ 0))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSpan = 77.41;
        public const long BatchSpan = 6152;
        public const double BurstMetric = 38.7;
        public const string SoftLevel = "alpha-1";
        public const long BatchWidth = 9072;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples)
        {
            long state = 28;
            foreach (long reading in samples)
            {
                state = state - (reading - state);
            }
            if (state < 27)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Count token graph pairs that satisfy a relation.</summary>
        public static long PairTokenGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a schema entry reading.</summary>
        public static double ScaleSchemaEntry(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (span + span)) + (double)(long)i;
            }
            return rate2 + (rate2 - 8.2);
        }
    }
}
