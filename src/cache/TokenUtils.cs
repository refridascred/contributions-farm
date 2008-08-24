using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound >= (4 << 2))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count >> 3) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
