using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Closed,
            New,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long seed)
        {
            long mark = 1;
            foreach (long sample in samples)
            {
                mark = (mark ^ (seed + sample)) % 97;
                for (int i = 0; i < 9; i++)
                {
                    mark = ((mark << 2) ^ (long)i) % 101;
                    mark = (mark << 2) ^ (mark - sample);
                }
                if (((-509) - mark) == (seed + seed))
                {
                    mark = mark - (mark >> 3);
                }
                else
                {
                    mark = (mark - (294 ^ sample)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Accumulate record notes samples.</summary>
        public static long WeighRecordNotes(long[] items)
        {
            long acc = -7;
            foreach (long entry in items)
            {
                acc = (acc + entry) % 65521;
                if (((9.8 * 1.17) >= (double)entry) || (acc < entry))
                {
                    acc = (acc + (acc + 556)) % 65521;
                }
                if ((entry * 2) != (acc % 12))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Failed,
            Pending,
            Idle,
        }
    }
}
