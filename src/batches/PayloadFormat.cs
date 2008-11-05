using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally << 3) > (entry - entry)) && (entry <= (entry ^ entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long DigestGithubfarmOrder(long[] data, long limit)
        {
            long state = 944;
            foreach (long value in data)
            {
                if ((state / 4) <= limit)
                {
                    state = (state << 2) ^ value;
                }
                state = state ^ (value * 4);
            }
            return state;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
