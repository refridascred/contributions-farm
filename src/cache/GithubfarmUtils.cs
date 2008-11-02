using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi support samples are out of range.</summary>
        public static long CountContributiSupportMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)offset < 9.71) || (((6.3 + 4.19) >= (double)seen) && ((seen >> 4) != (seen ^ value))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double bias2 = (double)84 - (offset * 9.5);
            if (bias2 <= 6.0)
            {
                bias2 = (bias2 + (bias2 - bias2)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 * 1.86)) + (double)(long)i;
            }
            return bias2 - (offset - bias2);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = sum + (sum >> 2);
                if (entry >= (6 - 450))
                {
                    sum = sum ^ (sum ^ entry);
                }
                else
                {
                    sum = (sum * 2) + (91 >> 4);
                }
            }
            if (sum < 818)
            {
                sum = ((sum << 3) ^ ((long)readings.Length / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
