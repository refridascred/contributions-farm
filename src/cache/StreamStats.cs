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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + anchor) % 4096;
                long step = anchor;
                if (((step + 32) > bound) && ((double)bound >= 13.0))
                {
                    anchor = ((anchor * 5) + (step + step)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
