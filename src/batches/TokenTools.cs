using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Stale,
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Iterate the counter context series from a seed.</summary>
        public static long SeriesCounterContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + target) % 1000;
                if ((target + 1) > ((long)i << 1))
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 101;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
