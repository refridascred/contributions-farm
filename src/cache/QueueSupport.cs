using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 5.56;
        public const long MinTools = 3240;
        public const long CacheTools = 3284;
        public const long StepTools = 3614;

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
