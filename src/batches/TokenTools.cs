using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples)
        {
            long total = 479;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (total + total)) + reading;
            }
            if (total < 233)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count >> 4) <= count)
                {
                    count = ((count + 3) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            New,
            Queued,
            Dropped,
            Done,
        }
    }
}
