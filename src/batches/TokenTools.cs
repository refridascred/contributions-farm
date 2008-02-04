using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length > (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
