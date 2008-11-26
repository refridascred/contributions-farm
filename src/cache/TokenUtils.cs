using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a contributi layout reading by value.</summary>
        public static long SeekContributiLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long target)
        {
            if ((7 & 1) < (target + target))
            {
                return 8;
            }
            else
            {
                if ((6.0 / 7.0) >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (((8 + 0) >= (bound % 10)) || (target > (target + target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target % 5) >= bound) || ((double)965 <= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
