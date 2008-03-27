using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum >> 1) != (datum % 7)) || ((double)datum <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a batches contributi reading by value.</summary>
        public static long FindBatchesContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long mix = 18;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ mix) % 1000) ^ item;
            }
            return mix;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
