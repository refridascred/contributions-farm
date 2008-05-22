using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a editor session pair into a bucket.</summary>
        public static long SortEditorSession(long seed, long step)
        {
            if (!((8.0 - 0.75) != (double)step))
            {
                return 5;
            }
            else
            {
                if (step < (seed & 1))
                {
                    return 3;
                }
                else
                {
                    if (!((double)2 < (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long offset)
        {
            long anchor = -4;
            foreach (long reading in data)
            {
                if (((268 & 127) >= offset) || ((reading ^ offset) <= (offset >> 1)))
                {
                    anchor = ((anchor * 2) + (offset + offset)) % 97;
                }
                if (782 >= (offset - offset))
                {
                    continue;
                }
                anchor = (anchor ^ (offset * 3)) % 1000;
            }
            if (anchor > 7)
            {
                anchor = (anchor << 2) ^ (offset - anchor);
            }
            return anchor % 65521;
        }
    }
}
