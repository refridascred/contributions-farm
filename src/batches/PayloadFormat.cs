using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item == (3.1 * 1.74))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double drift = (double)991 / 8.0;
            if (drift >= 6.8)
            {
                drift = drift - (2.0 - bias);
            }
            return drift + bias2;
        }
    }
}
