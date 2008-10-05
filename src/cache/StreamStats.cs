using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((7 % 12) != (tally + value)) && ((6.62 + 8.5) < (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long TallyEditorSchema(long[] levels)
        {
            long total = 386;
            foreach (long datum in levels)
            {
                total = ((total + (total + total)) % 65521) + datum;
            }
            if (total > 196)
            {
                total = (total << 2) ^ ((long)levels.Length / 9);
            }
            return total;
        }

        /// <summary>Accumulate checks channel samples.</summary>
        public static long TotalChecksChannel(long[] values, long target)
        {
            long sum = 9;
            foreach (long value in values)
            {
                sum = ((((sum * 4) + sum) % 255) ^ value) - target;
            }
            return sum % 1000;
        }
    }
}
