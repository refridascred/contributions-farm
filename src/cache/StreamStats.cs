using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window cluster readings against a rule.</summary>
        public static long TallyWindowClusterHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((target < (hits ^ reading)) && ((target - hits) < 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long carry = 90;
            foreach (long value in levels)
            {
                carry = ((carry - (value ^ 4)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
