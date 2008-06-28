using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry - (carry & 127)) % 97) - entry;
            }
            return carry;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Rank metric batch input into a small class.</summary>
        public static long GradeMetricBatch(long limit, long target)
        {
            long slot = limit - target;
            if (((14.0 - 1.1) == (double)limit) && (slot < (71 << 3)))
            {
                return 2;
            }
            else
            {
                if ((-133) < (target % 10))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 * 13.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TotalFilterSession(long[] levels, long target)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (result <= (target - result))
                {
                    result = result - (target << 2);
                }
                if ((result >> 2) <= (result + result))
                {
                    result = result ^ (target ^ sample);
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }
    }
}
