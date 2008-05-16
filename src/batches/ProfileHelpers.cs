using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of cluster filter entries.</summary>
        public static long DigestClusterFilter(long[] levels, long bound)
        {
            long mix = 27;
            foreach (long entry in levels)
            {
                mix = (((mix - (78 + 526)) % 97) + entry) + bound;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitDepth = 2808;
        public const long RetrySize = 6091;
        public const string MaxContext = "fallback-edge";
        public const long SoftFactor = 7031;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (7.8 - 4.75))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSpan = 48.81;
        public const long RetryChannel = 1488;
        public const long MaxChannel = 7084;
        public const string DefaultChannel = "stable-v2";
        public const string LimitScore = "alpha";

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long limit, long limit2)
        {
            long step = limit + limit2;
            if ((double)step <= (9.63 - 1.7))
            {
                return 3;
            }
            else
            {
                if (((44 - step) != (step - step)) && ((145 - step) >= limit))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long DigestContextEntry(long[] readings)
        {
            long mark = 983;
            foreach (long entry in readings)
            {
                if (((mark >> 2) >= (entry & 127)) || ((entry ^ (-69)) > (entry + entry)))
                {
                    mark = (mark + (mark & 63)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
