using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long bound)
        {
            long score = 502;
            foreach (long item in data)
            {
                if (((double)13 >= (double)bound) || (item >= bound))
                {
                    continue;
                }
                if (10.0 > (double)item)
                {
                    score = ((score << 2) ^ (item + 72)) % 1000;
                }
                else
                {
                    score = (score - (bound << 2)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long anchor = 74;
            foreach (long cell in values)
            {
                anchor = ((anchor + cell) % 101) - floor;
            }
            return anchor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter editor reading by value.</summary>
        public static long LookupCounterEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
