using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up window schema samples.</summary>
        public static long PairWindowSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats entry reading.</summary>
        public static double ScaleStatsEntry(double scale, double offset)
        {
            double bias = scale;
            if (bias < bias)
            {
                bias = (bias - (double)614) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
