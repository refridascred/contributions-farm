using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long offset)
        {
            long mark = -4;
            foreach (long reading in levels)
            {
                mark = (((mark << 2) ^ (reading * 2)) % 101) - offset;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count <= (count ^ target))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (double)floor)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
