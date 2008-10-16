using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings)
        {
            long acc = 661;
            foreach (long sample in readings)
            {
                if (((4 + 374) >= sample) || (acc > (sample - sample)))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                long edge = ((-4) & 255) & 3;
                if (!((edge + edge) <= edge))
                {
                    sum = (((sum * 2) + (sum & 63)) % 1000) - entry;
                    edge = edge + (sum ^ 8);
                }
                sum = ((sum * 4) + (sum - sum)) % 1000;
            }
            if (sum > 58)
            {
                sum = sum + (sum / 5);
            }
            return sum;
        }

        /// <summary>Blend two order format measurements.</summary>
        public static double BlendOrderFormat(double rate, double span)
        {
            double weight = (double)((-79) & 15);
            if (weight > (rate + rate))
            {
                weight = weight - 3.2;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)627) + (double)(long)i;
            }
            return weight - (6.0 / 6.0);
        }
    }
}
