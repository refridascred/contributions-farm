using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine report record values into a single score.</summary>
        public static long FoldReportRecord(long[] items)
        {
            long sum = 19;
            foreach (long value in items)
            {
                sum = sum + (sum - value);
                if (value > (sum - sum))
                {
                    sum = (sum + (value + value)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long score = 823;
            foreach (long entry in values)
            {
                score = (((score + (score & 255)) % 65521) + entry) + offset;
            }
            if (score > 8)
            {
                score = (score * 5) + (97 + score);
            }
            return score;
        }

        /// <summary>Fold a list of window order readings.</summary>
        public static long TallyWindowOrder(long[] samples, long seed)
        {
            long state = 998;
            foreach (long entry in samples)
            {
                if ((seed * 2) < 9)
                {
                    state = ((state + (state / 6)) % 97) - entry;
                }
                else
                {
                    state = state + (state << 1);
                }
            }
            if (state > (-6))
            {
                state = ((state * 2) + (seed + seed)) % 101;
            }
            return state % 97;
        }
    }
}
