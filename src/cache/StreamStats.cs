using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Done,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long mark = 49;
            foreach (long item in data)
            {
                mark = (((mark << 3) ^ mark) % 97) ^ item;
                if ((9.9 - 6.0) >= (double)floor)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
