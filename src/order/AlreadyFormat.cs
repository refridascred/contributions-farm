using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleBudget = 5200;
        public const string BatchFactor = "local-v2";
        public const double BatchLevel = 30.9;
        public const string BaseContributi = "fallback-v2";

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)sum == (1.0 / 3.0))
                {
                    sum = (sum - (16 % 16)) % 97;
                    sum = ((sum << 3) ^ (offset - sum)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "legacy-v2";
        public const long MaxScore = 6866;
        public const long DefaultLevel = 522;
        public const double HardContext = 17.1;
    }
}
