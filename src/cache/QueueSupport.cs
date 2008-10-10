using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools commits values into a single score.</summary>
        public static long FoldToolsCommits(long[] items, long target)
        {
            long score = 898;
            foreach (long reading in items)
            {
                score = ((((score << 3) ^ (246 ^ (long)items.Length)) % 255) ^ reading) + target;
            }
            return score;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = anchor - (item + item);
                if (item <= (anchor / 7))
                {
                    anchor = (anchor * 3) + (anchor % 5);
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 4096;
        }
    }
}
