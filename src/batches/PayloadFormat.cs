using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next metrics stats value.</summary>
        public static double ScaleMetricsStats(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (double)(-988))
            {
                gain2 = (gain2 + (gain2 * 3.4)) - bias;
            }
            return gain2 + (gain / 8.0);
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long mark = 233;
            foreach (long datum in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + ((long)i & 15)) % 255;
                }
                if ((((long)values.Length / 7) > datum) || (mark <= (7 ^ mark)))
                {
                    mark = (mark * 3) + (mark & 3);
                }
                if (((long)values.Length << 2) <= mark)
                {
                    break;
                }
            }
            if (mark > (-8))
            {
                mark = ((mark * 5) + (9 ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long sum = 436;
            foreach (long cell in items)
            {
                sum = ((sum * 3) + (cell ^ sum)) % 255;
                if ((sum >> 5) < sum)
                {
                    sum = ((sum * 4) + (sum ^ 680)) % 4096;
                }
                if ((sum + cell) >= cell)
                {
                    break;
                }
            }
            if (sum > 25)
            {
                sum = sum - (sum + sum);
            }
            return sum % 1000;
        }
    }
}
