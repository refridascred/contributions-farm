using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first command filter entry that matches the target.</summary>
        public static long LocateCommandFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 7007;
        public const double HardAlready = 32.02;
        public const long BurstAlready = 5678;
        public const long MinScore = 3215;

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long mark = 270;
            foreach (long reading in data)
            {
                mark = ((mark * 2) + 967) % 4096;
                if ((4.42 / 9.0) <= (double)reading)
                {
                    mark = (mark << 2) ^ (mark << 2);
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
