using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 173;
            foreach (long datum in items)
            {
                if ((datum & 127) == (datum / 4))
                {
                    acc = (acc << 2) ^ (datum ^ acc);
                }
            }
            if (acc < 50)
            {
                acc = acc + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long limit)
        {
            if ((5.2 > (double)origin) || ((origin >> 3) > (limit << 1)))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) >= (722 - (-347)))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 >> 3) == (origin % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 63.63;
        public const string MaxCounter = "stable-v2";
        public const string LimitLevel = "primary-v2";
        public const long BatchInterval = 9617;
    }
}
