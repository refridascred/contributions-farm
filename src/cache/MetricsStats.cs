using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                long span = (anchor + anchor) >> 5;
                long cur = ((long)i / 9) + ((long)i / 8);
                if ((floor + span) >= ((-993) ^ cur))
                {
                    span = (span - (anchor / 3)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                if (9.75 > (double)item)
                {
                    total = (total - total) % 255;
                }
                if ((double)item == (3.0 - 8.6))
                {
                    break;
                }
            }
            if (total < 239)
            {
                total = (total ^ (total - 85)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Find the first support stream entry that matches the target.</summary>
        public static long SeekSupportStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Locked,
            Failed,
        }
    }
}
