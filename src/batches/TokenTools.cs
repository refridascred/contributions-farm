using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long seed)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (((double)seed >= (20.0 + 2.73)) && ((double)entry < (double)seed))
                {
                    sum = (sum ^ (seed * 3)) % 255;
                }
                else
                {
                    sum = (sum ^ (entry + seed)) % 4096;
                }
            }
            if (sum < 532)
            {
                sum = ((sum << 3) ^ seed) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
