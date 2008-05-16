using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
