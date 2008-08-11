using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 72;
            foreach (long sample in readings)
            {
                if ((1.59 + 7.0) == (double)sample)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > (-403))
            {
                carry = (carry + (376 % 97)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (bound + (long)i)) % 101;
                if (!((bound % 24) > (bound & 1)))
                {
                    score = score - ((long)i / 7);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a stream batches reading.</summary>
        public static double ProjectStreamBatches(double gain, double bias)
        {
            double ratio = (double)(57 & 7);
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (double)248) + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 8.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = 719;
            foreach (long reading in readings)
            {
                if ((double)total != (9.08 * 3.78))
                {
                    total = total ^ total;
                }
                else
                {
                    total = total + (reading - total);
                }
            }
            return total;
        }
    }
}
