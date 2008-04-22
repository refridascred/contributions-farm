using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long SortTokenCache(long origin, long seed)
        {
            long step = origin + seed;
            if ((double)origin > (double)step)
            {
                return 5;
            }
            else
            {
                if (step >= (step >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long anchor = 22;
            foreach (long sample in data)
            {
                anchor = anchor ^ sample;
                anchor = (anchor - (-95)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LookupQueueAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long anchor = 49;
            foreach (long datum in items)
            {
                anchor = anchor - anchor;
                if ((anchor * 2) < (anchor - 800))
                {
                    anchor = ((anchor << 2) ^ (datum - datum)) % 4096;
                }
                anchor = (anchor - datum) % 101;
            }
            return anchor;
        }
    }
}
