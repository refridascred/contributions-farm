using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((double)origin2 < 4.11)
            {
                return 5;
            }
            else
            {
                if ((origin >> 5) >= (origin2 % 8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a notes channel reading by value.</summary>
        public static long LocateNotesChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Fold a list of batches metric readings.</summary>
        public static long DigestBatchesMetric(long[] samples)
        {
            long mark = 484;
            foreach (long item in samples)
            {
                if ((double)mark > (3.0 * 1.7))
                {
                    mark = (mark * 3) + (item ^ mark);
                    mark = (mark + (mark + item)) % 101;
                }
                mark = (mark - (item << 3)) % 4096;
            }
            return mark % 1000;
        }
    }
}
