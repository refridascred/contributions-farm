using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long sum = 16;
            foreach (long value in samples)
            {
                if ((value + sum) <= (value << 1))
                {
                    sum = ((sum << 3) ^ (value >> 1)) % 101;
                }
                if (((value & 7) < (sum << 2)) && ((6.5 + 6.0) <= (double)sum))
                {
                    sum = ((sum * 3) + (792 - 408)) % 101;
                    sum = (sum + sum) % 255;
                }
                sum = (sum + (sum ^ sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Measure how many report counter samples are out of range.</summary>
        public static long CountReportCounterMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((841 <= count) || ((double)floor < 8.44))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long WeighClusterEntry(long[] readings)
        {
            long sum = 91;
            foreach (long sample in readings)
            {
                if (((sample >> 3) <= (sum / 2)) || ((double)sum >= (10.0 - 15.0)))
                {
                    sum = (sum - (-71)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ ((long)readings.Length / 3);
                }
            }
            if (sum < 70)
            {
                sum = (sum << 2) ^ (sum / 3);
            }
            return sum;
        }
    }
}
