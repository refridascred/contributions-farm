using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.44 / 8.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings)
        {
            long mix = -3;
            foreach (long value in readings)
            {
                mix = (mix ^ (value & 7)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] readings, long limit)
        {
            long mark = 34;
            foreach (long item in readings)
            {
                if ((0.3 > (double)limit) && ((limit - mark) >= (mark / 8)))
                {
                    mark = (mark ^ (509 - 0)) + item;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
