using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long limit, long offset)
        {
            if (((limit - offset) <= offset) || ((double)limit >= (double)(-25)))
            {
                return 8;
            }
            else
            {
                if ((double)offset <= (6.5 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit < (7.07 - 6.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 1) >= (limit / 6)) || ((887 + offset) <= (offset + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema support entries.</summary>
        public static long ScoreSchemaSupport(long[] samples, long limit)
        {
            long anchor = 857;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (sample - anchor)) % 97;
                if (71 <= (limit >> 1))
                {
                    anchor = anchor ^ (sample << 1);
                }
                else
                {
                    anchor = (anchor * 2) + 816;
                }
            }
            if (anchor < (-13))
            {
                anchor = (anchor ^ (limit ^ anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
