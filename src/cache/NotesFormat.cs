using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster buffer samples are out of range.</summary>
        public static long CountClusterBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 1039;
        public const string LimitCache = "standard";
        public const string HardCount = "staging-v2";
        public const long MinSize = 6558;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = sum ^ (item + sum);
            }
            return sum % 1000;
        }
    }
}
