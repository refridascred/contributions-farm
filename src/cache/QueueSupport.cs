using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long BucketCacheContributi(long bound, long limit)
        {
            if (!((7.6 - 8.36) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}
