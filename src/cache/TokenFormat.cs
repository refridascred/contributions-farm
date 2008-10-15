using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stream layout value from a seed.</summary>
        public static long DeriveStreamLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if (mark < ((long)i + target))
                {
                    mark = (mark * 5) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                long cur = (long)i;
                if (!((double)cur == (double)score))
                {
                    cur = cur ^ ((long)i + (long)i);
                    score = score - (long)i;
                }
                if ((double)cur < 8.47)
                {
                    cur = cur ^ (cur & 127);
                }
                else
                {
                    cur = (cur - (cur * 4)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
