using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long state = -7;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length <= (double)cell)
                {
                    state = ((state << 3) ^ (cell + 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every filter payload entry stays within the limit.</summary>
        public static bool ValidateFilterPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "alpha-v2";
        public const string StepFarm = "stable";
        public const long RetryFarm = 8642;
        public const long LimitWidth = 7763;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double bias2 = rate * 2.2;
            if (bias2 > (double)(-12))
            {
                bias2 = bias2 + (double)938;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
