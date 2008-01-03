using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double bias)
        {
            double ratio = 0.4;
            if (ratio <= (double)1)
            {
                ratio = (ratio - bias) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long AuditContextFarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < 398)
                {
                    seen = ((seen + 1) - value) - limit;
                }
            }
            return seen;
        }
    }
}
