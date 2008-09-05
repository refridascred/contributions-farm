using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            if (!((seed & 1) < (step + seed)))
            {
                return 8;
            }
            else
            {
                if (((seed * 4) == (step - step)) || ((step + step) != (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5531;
        public const long WindowBudget = 7166;
        public const long DefaultDepth = 9852;

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry ^ (carry % 100)) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count < value)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
