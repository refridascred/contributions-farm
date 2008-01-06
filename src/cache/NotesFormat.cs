using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum + sum);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings)
        {
            long mark = 43;
            foreach (long reading in readings)
            {
                mark = ((mark + mark) % 97) - reading;
                mark = ((mark << 2) ^ 9) % 101;
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 8214;
        public const long StepDepth = 1598;
        public const long StepCache = 6777;
    }
}
