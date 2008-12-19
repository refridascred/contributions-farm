using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long TallyToolsGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 5;
            foreach (long reading in series)
            {
                anchor = ((anchor * 3) + (reading << 1)) % 255;
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
