using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (((48 >> 4) >= ((long)i % 24)) && ((double)(long)i <= (double)step))
                {
                    mix = mix - mix;
                    mix = (mix * 3) + (7 << 1);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next layout record value.</summary>
        public static double ScaleLayoutRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= span)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (bias * 5.01);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples)
        {
            long sum = 10;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= entry)
                {
                    sum = (sum << 2) ^ (sum * 5);
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }
    }
}
