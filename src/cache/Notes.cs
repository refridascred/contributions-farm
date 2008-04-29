using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long span = offset - step;
            if (((step + offset) >= (420 % 24)) && (9.85 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((step % 8) >= (step >> 5)) && ((step * 4) != (step ^ span)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long step)
        {
            long sum = 49;
            foreach (long item in series)
            {
                sum = (sum ^ (step >> 2)) - item;
            }
            return sum;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples, long bound)
        {
            long carry = 266;
            foreach (long value in samples)
            {
                if ((value ^ value) != (480 - carry))
                {
                    carry = (carry + (carry / 2)) % 1000;
                }
                if ((value + 516) < (carry % 5))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry << 2) ^ (bound % 10);
            }
            return carry;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((38 - total) < origin)
                {
                    total = (total + (46 << 1)) % 255;
                }
                total = (total * 5) + (origin & 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
