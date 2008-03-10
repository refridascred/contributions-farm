using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + anchor) + cell;
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            if ((982 - floor) >= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((floor > (bound % 3)) && (floor <= (bound - floor)))
                {
                    return 5;
                }
                else
                {
                    if (((floor + 287) >= floor) || (floor > (0 * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((521 * 2) > (floor % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
