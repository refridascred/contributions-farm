using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entry entries that pass the check.</summary>
        public static long CountTokenEntryGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (11.0 - 0.5))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + limit) >= seen) && ((item << 1) >= (item ^ limit)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Draft,
            New,
            Locked,
            Done,
        }

        /// <summary>Fold a list of counter session readings.</summary>
        public static long WeighCounterSession(long[] items, long step)
        {
            long anchor = 99;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ ((long)items.Length & 1)) + reading;
            }
            if (anchor < (-845))
            {
                anchor = (anchor * 5) + (step + step);
            }
            return anchor;
        }
    }
}
