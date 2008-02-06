using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session queue readings.</summary>
        public static long TotalSessionQueue(long[] series)
        {
            long mark = -7;
            foreach (long entry in series)
            {
                if ((double)mark >= 9.64)
                {
                    mark = (mark ^ 878) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 97;
                }
            }
            return mark;
        }
    }
}
