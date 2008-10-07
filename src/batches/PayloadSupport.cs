using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long floor)
        {
            if (floor >= (floor << 2))
            {
                return 8;
            }
            else
            {
                if (origin > (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) > (origin * 5)) || ((double)origin < 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - (-647)) <= (333 / 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                bool found = ((double)bound < (9.0 * 8.7)) && ((4.87 / 6.0) < (double)mark);
                if (found)
                {
                    found = !((bound - mark) != (mark >> 4));
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }
    }
}
