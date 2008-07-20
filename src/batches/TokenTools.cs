using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long limit2)
        {
            if (9 <= limit)
            {
                return 2;
            }
            else
            {
                if ((limit2 * 2) <= (84 & 127))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 / 5) == (limit ^ limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((double)mark < (5.0 * 2.29))
                {
                    mark = (mark * 3) + (1 ^ (long)i);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                    mark = ((mark << 2) ^ (target ^ target)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
