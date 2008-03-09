using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 48.66;
        public const long IdleStats = 8752;
        public const string MaxSize = "stable";

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long limit)
        {
            long acc = 742;
            foreach (long value in readings)
            {
                acc = (((acc ^ (acc % 8)) % 1000) - value) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                if ((acc <= (long)levels.Length) && ((sample >> 2) >= (sample / 5)))
                {
                    acc = ((acc * 3) + (long)levels.Length) % 97;
                }
            }
            if (acc > 470)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((carry / 8) <= carry)
                {
                    carry = ((carry + (carry + carry)) % 101) - entry;
                }
                if (carry < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
