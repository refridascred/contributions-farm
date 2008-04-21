using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (87 * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((origin & 3) != (origin - gap))
            {
                return 6;
            }
            else
            {
                if (((gap + origin) > (origin << 2)) || (gap < (limit - gap)))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (origin << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < ((-25) + 109))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
