using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema order entries.</summary>
        public static long TallySchemaOrder(long[] levels)
        {
            long total = 925;
            foreach (long datum in levels)
            {
                if (((3.7 / 3.0) >= (double)datum) || ((total + datum) < total))
                {
                    total = (total ^ (total - total)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total;
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
