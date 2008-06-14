using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel queue readings.</summary>
        public static long TallyChannelQueue(long[] samples, long limit)
        {
            long mark = -725;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark ^ (mark + sample)) % 255) + (long)i;
                }
                mark = ((mark * 4) + limit) % 101;
                if (((4.9 - 12.0) >= (double)limit) && (((-54) ^ limit) >= 22))
                {
                    mark = (mark - (mark - 342)) % 101;
                }
                if ((mark % 7) < (3 + limit))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
