using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long seed)
        {
            long mark = 809;
            foreach (long item in samples)
            {
                mark = (mark ^ (item + item)) + seed;
            }
            return mark;
        }

        /// <summary>Look up the position of a context stream sample.</summary>
        public static long SeekContextStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin * 4) < (seen / 6))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
