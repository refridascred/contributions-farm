using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit + (long)i) < limit)
                {
                    mark = (mark ^ ((long)i >> 5)) % 4096;
                }
                else
                {
                    mark = mark - (limit ^ mark);
                    mark = (mark ^ (mark + limit)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
