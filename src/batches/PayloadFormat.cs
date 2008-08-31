using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support route entries that pass the check.</summary>
        public static long CountSupportRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) != (seen & 1)) || !((9.0 / 2.0) != (double)value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer commits samples.</summary>
        public static long CompareBufferCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (span * 5.83) - (span * 4.2);
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean - (weight + mean);
        }

        /// <summary>Compare every pair of route schema readings.</summary>
        public static long CompareRouteSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
