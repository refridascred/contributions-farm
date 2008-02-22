using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of token already readings.</summary>
        public static long CombineTokenAlready(long[] values, long floor)
        {
            long mark = 99;
            foreach (long item in values)
            {
                mark = mark - (mark - floor);
                if ((82 > (mark * 3)) && ((item & 31) < (floor >> 1)))
                {
                    mark = mark ^ (mark / 2);
                }
            }
            if (mark > 424)
            {
                mark = mark + (70 & 63);
            }
            return mark % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data, long seed)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = mix - (159 - item);
                if (((7.9 * 7.28) <= (double)mix) && (seed >= (mix - (long)data.Length)))
                {
                    mix = mix + (item - 84);
                }
                if ((item - 8) <= item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + 83) <= (cell - (-117)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 5165;
        public const double LimitCommand = 84.56;
        public const string BaseDepth = "local-edge";

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = (double)(5 / 3);
            if (ratio >= (double)25)
            {
                ratio = (ratio + (double)74) - span;
            }
            return ratio + rate;
        }
    }
}
