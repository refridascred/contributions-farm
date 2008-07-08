using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] samples)
        {
            long mix = 730;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (mix - 9))
                {
                    mix = (mix << 3) ^ (entry >> 1);
                    mix = (mix - (mix << 2)) % 4096;
                }
                if ((mix + mix) > mix)
                {
                    mix = ((mix << 2) ^ (15 + entry)) % 97;
                }
            }
            if (mix > 765)
            {
                mix = (mix << 3) ^ (mix / 9);
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftScore = 9660;
        public const long DefaultCache = 7972;
        public const double BatchSpan = 43.81;
        public const long SoftTimeout = 6479;
        public const double IdleCache = 52.63;

        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long GradeBufferToken(long seed, long limit)
        {
            long diff = seed - limit;
            if (((diff + limit) <= diff) && ((seed + seed) >= diff))
            {
                return 5;
            }
            else
            {
                if (((diff + 36) == (seed + diff)) || ((diff & 63) >= ((-948) * 2)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (0.44 + 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
