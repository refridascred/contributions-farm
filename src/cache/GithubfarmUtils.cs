using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long carry = 268;
            foreach (long reading in series)
            {
                if ((carry + 86) < (reading + (-40)))
                {
                    carry = ((carry << 2) ^ ((long)series.Length - reading)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double weight = (bias2 * 5.3) + bias2;
            if (weight >= bias2)
            {
                weight = weight + (bias2 / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)302;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultWidth = "alpha";
        public const long BatchGraph = 9517;
        public const long RetryGraph = 2114;
        public const long MaxInterval = 5681;
        public const string HardGraph = "open-edge";
    }
}
