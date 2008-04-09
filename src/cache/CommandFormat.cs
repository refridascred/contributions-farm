using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long acc = 27;
            foreach (long item in items)
            {
                if (acc <= (68 % 64))
                {
                    acc = (acc * 2) + acc;
                }
                else
                {
                    acc = acc ^ (-32);
                    acc = (acc << 3) ^ step;
                }
                acc = (acc - (acc & 63)) % 65521;
                if (!((item + acc) != (acc + acc)))
                {
                    acc = (acc ^ (item & 1)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "fallback";
        public const double BurstScore = 53.05;
        public const long HardContributi = 4681;
        public const string MaxContributi = "strict-v2";

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)floor > 3.8) && ((908 >> 2) < (total % 2)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 4167;
        public const string HardWidth = "open-1";
        public const long RetryTimeout = 3541;
    }
}
