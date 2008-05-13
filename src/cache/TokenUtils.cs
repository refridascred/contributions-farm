using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 7260;
        public const long DefaultLevel = 3146;
        public const long MinNotes = 7672;
        public const string WindowNotes = "staging-1";
        public const long SoftNotes = 3908;

        /// <summary>Combine commits account values into a single score.</summary>
        public static long WeighCommitsAccount(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long value in data)
            {
                if ((value + 53) > anchor)
                {
                    anchor = (anchor << 3) ^ (159 + limit);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 644;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ entry) % 97;
            }
            return mark % 1000;
        }
    }
}
