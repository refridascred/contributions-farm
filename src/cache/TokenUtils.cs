using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long sum = 723;
            foreach (long sample in values)
            {
                if ((sample - sample) != (sample - 4))
                {
                    sum = ((sum << 2) ^ (94 >> 5)) % 1000;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double gain = 2.91 - offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (weight + 7.7)) - (double)(long)i;
            }
            return gain - (weight - weight);
        }

        /// <summary>Fold a list of payload format readings.</summary>
        public static long TallyPayloadFormat(long[] values, long limit)
        {
            long acc = 43;
            foreach (long item in values)
            {
                acc = ((acc * 2) + (acc - item)) - limit;
            }
            if (acc < 42)
            {
                acc = (acc - (acc % 24)) % 1000;
            }
            return acc % 4096;
        }
    }
}
