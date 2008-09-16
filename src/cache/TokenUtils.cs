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

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long target)
        {
            long next = limit ^ target;
            if ((90 - target) < limit)
            {
                return 7;
            }
            else
            {
                if (((-427) / 5) <= (limit + 10))
                {
                    return 0;
                }
                else
                {
                    if (((target >> 3) >= (target + next)) || (((-36) % 64) <= (next - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
