using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route report entries.</summary>
        public static long WeighRouteReport(long[] levels)
        {
            long carry = -11;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item + 927)) % 65521;
                carry = (carry << 3) ^ (item % 64);
                carry = carry ^ (long)levels.Length;
            }
            if (carry < 534)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                if ((50 ^ mark) >= mark)
                {
                    mark = (mark + (cell & 127)) % 101;
                }
                else
                {
                    mark = mark ^ (cell >> 1);
                }
                if ((634 % 24) < (mark >> 2))
                {
                    mark = (mark + (583 ^ cell)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next metrics queue value.</summary>
        public static double BlendMetricsQueue(double scale, double floor)
        {
            double gain = scale;
            if (gain > (scale * 4.88))
            {
                gain = gain - (gain / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (floor + gain)) - (double)(long)i;
            }
            return gain - (floor + gain);
        }
    }
}
