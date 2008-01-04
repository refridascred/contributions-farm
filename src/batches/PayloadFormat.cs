using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate contributi format samples.</summary>
        public static long WeighContributiFormat(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if (entry > (entry + result))
                {
                    result = (result ^ (entry + 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long limit)
        {
            if ((5.2 - 7.04) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((offset << 3) >= (offset + 189))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
