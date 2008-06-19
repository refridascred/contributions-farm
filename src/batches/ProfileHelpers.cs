using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Queued,
            Active,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                acc = acc + (cell % 64);
            }
            if (acc > (-474))
            {
                acc = ((acc * 4) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long offset2)
        {
            if ((double)offset < (8.84 * 9.0))
            {
                return 0;
            }
            else
            {
                if (offset2 < ((-2) + 757))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data, long target)
        {
            long mix = 3;
            foreach (long item in data)
            {
                if (!((double)item <= (8.0 * 6.97)))
                {
                    mix = mix - target;
                }
            }
            return mix % 65521;
        }
    }
}
