using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long seed)
        {
            long mark = 78;
            foreach (long datum in samples)
            {
                if ((9.16 / 2.0) == (double)datum)
                {
                    mark = (mark ^ (mark - mark)) % 101;
                }
                else
                {
                    mark = (mark - seed) % 1000;
                }
            }
            if (mark < 318)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double scale, double floor)
        {
            double bias = (double)(503 - 510);
            if (bias > bias)
            {
                bias = bias - (scale - 5.62);
            }
            else
            {
                bias = bias - (floor - bias);
            }
            return bias + (1.41 - scale);
        }
    }
}
