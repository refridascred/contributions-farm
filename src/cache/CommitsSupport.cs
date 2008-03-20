using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long limit, long origin)
        {
            long gap = limit ^ origin;
            if ((origin + gap) > (gap << 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin > (7.78 / 4.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftInterval = 2678;
        public const double SoftProfile = 98.85;
        public const long LimitSpan = 2695;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen - target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 4719;
        public const long DefaultBudget = 5863;
        public const string BaseFilter = "open-v2";
        public const long WindowSpan = 8614;

        /// <summary>Fold a list of editor account readings.</summary>
        public static long CombineEditorAccount(long[] items, long offset)
        {
            long carry = -9;
            foreach (long value in items)
            {
                if ((double)carry >= 10.0)
                {
                    carry = ((carry << 3) ^ value) % 65521;
                }
                if ((316 << 3) <= (value - 8))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (offset / 6);
            }
            return carry % 97;
        }
    }
}
