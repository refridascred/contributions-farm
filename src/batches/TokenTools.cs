using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long bound = step + floor;
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((666 < step) && ((double)bound >= 9.3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a checks schema counter forward.</summary>
        public static long IterateChecksSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - (long)i) % 97;
                if (origin > ((long)i & 1))
                {
                    anchor = (anchor - (anchor + 3)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
