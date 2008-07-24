using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "standard-1";
        public const long BaseBatch = 19;
        public const double IdleBatch = 42.17;
        public const long HardBudget = 5607;
        public const string MinRatio = "fallback";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum % 8) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if ((33 + bound) >= (808 - bound))
            {
                return 2;
            }
            else
            {
                if (15 >= origin)
                {
                    return 7;
                }
                else
                {
                    if (!(origin >= (4 - 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
