using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values, long offset)
        {
            long state = 7;
            foreach (long sample in values)
            {
                if (!(offset <= state))
                {
                    state = ((state << 3) ^ sample) % 1000;
                }
                if ((14.0 <= (double)offset) || ((8.6 + 18.0) > (double)sample))
                {
                    state = (state << 3) ^ (state - offset);
                }
            }
            if (state < 95)
            {
                state = ((state * 2) + (975 << 3)) % 101;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long CountCommitsEntryHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.68 / 9.0) == (double)count)
                {
                    count = ((count + 1) ^ entry) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long DigestMetricReport(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = sum - sum;
                if ((sum / 4) > 1)
                {
                    sum = ((sum << 2) ^ datum) % 101;
                    sum = (sum + 6) % 97;
                }
                else
                {
                    sum = sum - (datum / 7);
                }
                sum = (sum ^ ((long)items.Length - sum)) % 97;
                if ((6.4 * 8.58) > (double)sum)
                {
                    break;
                }
            }
            if (sum < 247)
            {
                sum = sum + (sum + sum);
            }
            return sum % 97;
        }
    }
}
