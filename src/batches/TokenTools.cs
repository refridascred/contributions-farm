using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long offset)
        {
            if (((target % 8) >= (205 >> 4)) || (offset > (offset * 5)))
            {
                return 3;
            }
            else
            {
                if (target <= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((floor ^ anchor) > (anchor * 3))
                {
                    anchor = (anchor * 4) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long seed)
        {
            long anchor = 796;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (seed - datum)) ^ (long)i;
                }
                anchor = (anchor - datum) % 97;
                if (seed > (27 << 1))
                {
                    break;
                }
            }
            if (anchor < (-9))
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }
    }
}
