using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine commits stream values into a single score.</summary>
        public static long FoldCommitsStream(long[] values)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                double ratio = (double)sum;
                if ((double)sum >= ratio)
                {
                    ratio = ratio + (ratio / 5.0);
                }
                if ((7 + sum) >= (datum + 7))
                {
                    sum = sum + (sum / 9);
                }
                else
                {
                    sum = sum - (sum - sum);
                }
                if (!(((long)values.Length + sum) < (datum % 5)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((9.25 * 16.0) > (double)offset))
                {
                    state = (state * 4) + offset;
                }
                else
                {
                    state = state + (53 ^ (long)i);
                }
                state = state ^ (state & 7);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
