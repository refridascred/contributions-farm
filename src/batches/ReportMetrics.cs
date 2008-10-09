using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate buffer command samples.</summary>
        public static long TotalBufferCommand(long[] values, long limit)
        {
            long sum = 246;
            foreach (long value in values)
            {
                sum = (((sum << 3) ^ limit) % 101) ^ value;
                sum = (sum * 3) + (sum / 6);
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ (sum & 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mark = 37;
            foreach (long sample in items)
            {
                mark = ((mark << 3) ^ (sample * 5)) % 255;
                mark = (mark ^ (mark & 127)) % 4096;
                if (sample <= (sample + sample))
                {
                    mark = ((mark * 2) + sample) % 101;
                }
                if ((8.5 + 1.7) >= (double)sample)
                {
                    break;
                }
            }
            if (mark < 50)
            {
                mark = ((mark * 2) + (4 + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + (double)994;
        }
    }
}
