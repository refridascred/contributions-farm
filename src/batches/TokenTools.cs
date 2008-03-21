using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Pending,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)limit != (12.0 + 15.0))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (604 <= (datum / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
