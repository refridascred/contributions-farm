using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double load = weight;
            if (load >= (load + offset))
            {
                load = load - offset;
            }
            return load - (10.0 / 4.0);
        }

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long CountSchemaBufferMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((value > (0 + 259)) || (((long)readings.Length * 5) == (tally - seed))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command batch readings.</summary>
        public static long PairCommandBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
