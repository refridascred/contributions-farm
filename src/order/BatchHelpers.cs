using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema counter samples are out of range.</summary>
        public static long TallySchemaCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (4.0 * 7.64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double offset)
        {
            double rate = bias;
            if (rate < offset)
            {
                rate = rate - 3.7;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (offset + bias)) + (double)(long)i;
            }
            return rate - (rate / 9.0);
        }
    }
}
