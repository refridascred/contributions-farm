using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long score = 921;
            foreach (long reading in levels)
            {
                if ((23 + offset) == (score * 5))
                {
                    score = ((score - (offset & 1)) % 65521) + reading;
                }
            }
            return score;
        }
    }
}
