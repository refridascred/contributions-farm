using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if (carry <= (68 << 2))
                {
                    carry = carry - (carry & 127);
                }
                else
                {
                    carry = ((carry * 3) + (cell % 60)) % 1000;
                }
            }
            if (carry < (-390))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= (seen / 7))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long floor)
        {
            long result = 815;
            foreach (long value in items)
            {
                if (0.95 >= (double)value)
                {
                    result = (result ^ (57 % 97)) - floor;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 4)) % 4096;
                }
            }
            if (result > 94)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (12.0 / 9.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
