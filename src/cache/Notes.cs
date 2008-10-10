using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((bound > (seen & 31)) || ((seen + 2) < (bound + (-466)))) || (((bound ^ seen) >= 7) && ((double)seen < (6.82 / 7.0))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 662;
        public const long BurstAccount = 4638;
        public const long LimitTimeout = 1879;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 130;
        public const long LimitDepth = 7972;
        public const long LimitSize = 632;

        /// <summary>Adjust a already cache reading.</summary>
        public static double ScaleAlreadyCache(double gain, double offset)
        {
            double ratio = (double)(9 - 1);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - ratio) - (double)(long)i) - gain) + offset;
            }
            return ratio + (ratio * 5.0);
        }
    }
}
