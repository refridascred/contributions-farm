using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + mark) % 1000;
                if (!((long)i >= ((long)i - (long)i)))
                {
                    mark = (mark << 3) ^ ((long)i ^ (long)i);
                }
                else
                {
                    mark = mark + (target - (-45));
                }
                if ((target <= (target - (long)i)) && ((mark / 7) > (mark % 60)))
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor << 3) ^ 2;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long target)
        {
            long span = step + target;
            if ((target - span) > target)
            {
                return 3;
            }
            else
            {
                if ((span + target) > ((-999) & 7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
