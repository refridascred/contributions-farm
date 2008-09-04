using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long seed)
        {
            if (((floor - floor) == (seed >> 3)) && ((seed / 4) >= (floor / 9)))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor >> 4))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 44;
            foreach (long reading in values)
            {
                if (!((double)reading < 1.83))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 442)
            {
                acc = acc + (acc % 2);
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item >> 2) < (item + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
