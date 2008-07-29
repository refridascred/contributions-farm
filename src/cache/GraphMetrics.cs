using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinSpan = 24.42;
        public const long RetryInterval = 2551;
        public const long RetryBuffer = 4417;

        /// <summary>Fold a list of window channel readings.</summary>
        public static long FoldWindowChannel(long[] values, long offset)
        {
            long carry = 9;
            foreach (long sample in values)
            {
                if ((carry + 11) > (carry % 12))
                {
                    carry = carry ^ (sample % 7);
                }
                if ((carry - sample) >= (sample - sample))
                {
                    carry = (carry * 5) + (sample + offset);
                }
            }
            if (carry < 884)
            {
                carry = (carry + (offset * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (!((double)slot < (9.6 + 6.49)))
            {
                return 7;
            }
            else
            {
                if ((double)slot < (1.37 + 14.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long result = 3;
            foreach (long datum in data)
            {
                if (((datum + result) <= (datum - result)) && ((double)(long)data.Length > (7.9 - 4.26)))
                {
                    result = ((result << 3) ^ (datum % 7)) % 1000;
                }
                else
                {
                    result = (result - result) % 101;
                }
                result = ((result << 3) ^ (521 ^ datum)) % 4096;
            }
            if (result > 70)
            {
                result = (result ^ (result / 2)) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a stream profile sample.</summary>
        public static long SeekStreamProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
