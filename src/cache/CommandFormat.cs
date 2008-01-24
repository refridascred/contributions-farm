using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double load = offset;
            if (load > load)
            {
                load = load + (double)361;
            }
            else
            {
                load = load + load;
            }
            return load - (bias / 6.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxScore = 9655;
        public const long MinBatch = 2980;
        public const long RetryBatch = 646;
        public const long SoftBatch = 7400;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum - (sum + 8)) % 1000) + datum;
                }
            }
            if (sum > 279)
            {
                sum = sum + (origin + origin);
            }
            return sum % 1000;
        }
    }
}
