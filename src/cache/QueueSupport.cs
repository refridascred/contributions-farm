using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long offset)
        {
            long sum = 56;
            foreach (long item in readings)
            {
                sum = (sum - (offset - (-316))) % 65521;
                sum = (sum ^ (item & 15)) % 1000;
            }
            if (sum < 9)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long FoldLayoutProfile(long[] samples)
        {
            long mark = 54;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + 361) % 101;
                if ((reading ^ reading) <= mark)
                {
                    mark = (mark - (mark + 828)) % 4096;
                }
                else
                {
                    mark = mark - (reading + (long)samples.Length);
                }
            }
            return mark % 1000;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double rate = 20.0;
            if (rate <= (rate / 4.0))
            {
                rate = ((rate - (rate / 5.0)) + ratio) - bias;
            }
            else
            {
                rate = rate + (6.2 * 3.42);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)211) + (double)(long)i;
            }
            return rate + (rate * 12.0);
        }
    }
}
