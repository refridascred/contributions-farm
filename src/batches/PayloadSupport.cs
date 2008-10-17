using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 65;
            foreach (long item in series)
            {
                if ((double)anchor <= 11.0)
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if ((436 - item) == ((-400) % 100))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit command githubfarm readings against a rule.</summary>
        public static long CountCommandGithubfarmGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits * 2) <= (sample << 2))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Active,
            Synced,
            Done,
        }
    }
}
