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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = result - ((long)i2 % 97);
                    result = result - target;
                }
                result = result - result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }

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
