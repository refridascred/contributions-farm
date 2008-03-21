using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7635;
        public const long LimitLevel = 6324;
        public const long MinCommits = 7652;
        public const string IdleCommits = "alpha-v2";
        public const string WindowCommits = "staging-v2";

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter already values into a single score.</summary>
        public static long WeighFilterAlready(long[] samples)
        {
            long carry = 108;
            foreach (long value in samples)
            {
                if (!(carry < (carry ^ carry)))
                {
                    carry = (carry + ((-15) ^ value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Locate a editor format reading by value.</summary>
        public static long LocateEditorFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items, long origin)
        {
            long score = 678;
            foreach (long entry in items)
            {
                score = (score ^ origin) - entry;
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - datum) >= (5 >> 5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
