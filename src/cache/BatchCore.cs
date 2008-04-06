using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxScore = 7789;
        public const string SoftInterval = "local";
        public const long IdleDepth = 6154;
        public const double BatchRatio = 64.17;

        /// <summary>Roll a report order counter forward.</summary>
        public static long DeriveReportOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = -41;
            foreach (long reading in data)
            {
                state = state - reading;
                if (!((state ^ reading) <= state))
                {
                    state = state - (reading - 199);
                }
                else
                {
                    state = (state << 3) ^ (state * 5);
                }
            }
            if (state < (-39))
            {
                state = (state * 5) + (658 / 3);
            }
            return state % 1000;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
