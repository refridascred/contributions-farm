using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long ScoreProfileAlready(long[] items, long offset)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (((anchor * 4) + sample) % 65521) - offset;
            }
            if (anchor > 327)
            {
                anchor = anchor + 394;
            }
            return anchor % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
