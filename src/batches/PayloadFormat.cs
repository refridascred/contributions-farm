using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 1) == (hits + hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first githubfarm channel entry that matches the target.</summary>
        public static long FindGithubfarmChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if ((((-302) & 31) != (sample << 2)) && ((sample & 15) <= (4 % 16)))
                {
                    carry = (carry << 3) ^ (carry << 3);
                }
            }
            return carry;
        }

        /// <summary>Count channel batch pairs that satisfy a relation.</summary>
        public static long CompareChannelBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
