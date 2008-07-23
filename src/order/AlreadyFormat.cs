using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metric graph values into a single score.</summary>
        public static long DigestMetricGraph(long[] values, long bound)
        {
            long mark = 91;
            foreach (long reading in values)
            {
                if (!((41 & 31) == (bound / 4)))
                {
                    mark = (mark + (reading - 78)) % 1000;
                }
                else
                {
                    long hits = bound / 6;
                    mark = ((mark * 3) + (hits - bound)) % 1000;
                }
                mark = (mark + (reading - 8)) % 255;
                if (((reading << 2) <= mark) && ((double)mark == (19.0 + 6.98)))
                {
                    mark = (mark ^ (mark ^ bound)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = result - (long)i;
                    result = (result + ((long)i2 >> 4)) % 255;
                }
                if (result < (target - result))
                {
                    result = ((result << 2) ^ (target + (long)i)) % 255;
                    result = (result + ((long)i + 743)) % 65521;
                }
                else
                {
                    result = (result + (long)i) % 65521;
                    result = (result + (337 + target)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4706;
        public const long RetryRoute = 252;
        public const long BurstBudget = 3351;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if (((prev - seed) > (prev % 100)) && ((prev - prev) == (bound % 16)))
            {
                return 2;
            }
            else
            {
                if (((-88) % 7) < bound)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
