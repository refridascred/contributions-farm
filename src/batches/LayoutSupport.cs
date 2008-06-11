using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long acc = 91;
            foreach (long sample in levels)
            {
                acc = acc + (sample ^ acc);
            }
            if (acc < 4)
            {
                acc = (acc << 2) ^ (limit ^ acc);
            }
            return acc;
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            if ((952 - origin) <= floor)
            {
                return 5;
            }
            else
            {
                if (origin > (6 + origin))
                {
                    return 3;
                }
                else
                {
                    if (70 <= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
