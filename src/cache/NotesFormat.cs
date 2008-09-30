using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data, long target)
        {
            long mark = 56;
            foreach (long item in data)
            {
                mark = (mark * 4) + (target + item);
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardBudget = 6339;
        public const string IdleScore = "open-v2";
        public const double DefaultFilter = 88.04;
        public const long RetryFilter = 8813;
        public const long MaxTimeout = 9926;

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 25;
            foreach (long datum in levels)
            {
                if ((double)datum < 2.4)
                {
                    result = (result + 101) % 65521;
                }
                if ((result ^ result) < (result + datum))
                {
                    result = ((result * 2) + (result / 3)) % 97;
                }
                else
                {
                    result = (result << 2) ^ (result / 6);
                }
            }
            return result % 65521;
        }
    }
}
