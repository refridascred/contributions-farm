using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples, long floor)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                sum = ((sum << 2) ^ datum) % 255;
            }
            if (sum < 84)
            {
                sum = sum ^ (sum + floor);
            }
            return sum % 1000;
        }

        /// <summary>Accumulate window cluster samples.</summary>
        public static long CombineWindowCluster(long[] series, long limit)
        {
            long carry = 325;
            foreach (long sample in series)
            {
                carry = ((carry - (sample * 5)) % 255) - limit;
                carry = (carry ^ (sample & 7)) % 65521;
            }
            return carry;
        }

        /// <summary>Count contributi entry pairs that satisfy a relation.</summary>
        public static long CompareContributiEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
