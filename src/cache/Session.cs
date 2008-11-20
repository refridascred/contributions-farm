using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 84.46;
        public const double StepSpan = 19.7;
        public const long MaxChannel = 2101;
        public const string WindowChannel = "alpha";

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 94;
            foreach (long item in values)
            {
                if ((double)item < (0.1 - 5.0))
                {
                    carry = ((carry << 2) ^ (70 % 24)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long DeriveContextAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (mark ^ (long)i)) % 101;
                mark = (mark << 3) ^ ((long)i & 7);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
