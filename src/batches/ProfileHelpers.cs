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

        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long origin, long floor)
        {
            if ((origin + origin) >= floor)
            {
                return 0;
            }
            else
            {
                if ((74 & 3) != (origin % 12))
                {
                    return 6;
                }
                else
                {
                    if (((floor ^ origin) > (floor << 3)) || ((double)floor <= (7.0 + 3.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin <= (8.1 - 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
