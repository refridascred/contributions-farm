using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight > (bias * 9.9))
            {
                weight = (weight - (double)831) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (1.0 * 8.11)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((score ^ limit) < (score * 3)))
                {
                    score = (score + (limit << 2)) % 255;
                    score = (score * 2) + limit;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + (282 + (long)i2)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count & 15) <= ((-45) * 3))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer report entries.</summary>
        public static long CombineBufferReport(long[] values)
        {
            long result = 943;
            foreach (long cell in values)
            {
                if ((9.0 - 6.6) <= (double)result)
                {
                    result = ((result << 3) ^ (952 << 1)) - cell;
                }
            }
            if (result > 79)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result % 1000;
        }
    }
}
