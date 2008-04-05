using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long carry = 224;
            foreach (long reading in samples)
            {
                if (((target >> 4) != (target & 15)) && ((carry << 2) < (reading ^ reading)))
                {
                    carry = ((carry * 5) + (reading - target)) % 1000;
                    carry = carry + (reading ^ target);
                }
                if (((-5) + 464) < (carry ^ 629))
                {
                    carry = (carry ^ ((long)samples.Length & 15)) % 255;
                }
                else
                {
                    carry = carry ^ (target >> 5);
                }
            }
            if (carry > 328)
            {
                carry = ((carry * 4) + (carry >> 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (count + 534))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long StepChecksStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + 92) % 255;
                long count = 496 % 64;
                if ((target & 31) <= (count - (long)i))
                {
                    count = ((count << 2) ^ (target << 1)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a context stream counter forward.</summary>
        public static long SeriesContextStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - ((long)i + mix)) % 1000;
                if ((limit <= ((long)i << 2)) || (((long)i + limit) >= limit))
                {
                    mix = ((mix << 2) ^ (784 / 5)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 4884;
        public const long SoftFilter = 875;
        public const long BaseCount = 4381;
    }
}
