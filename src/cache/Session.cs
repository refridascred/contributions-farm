using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((floor + seen) > seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long acc = 690;
            foreach (long cell in values)
            {
                acc = (acc << 3) ^ (acc + acc);
                acc = ((acc << 3) ^ cell) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((0.6 + 6.91) == (double)(long)items.Length))
                {
                    tally = ((tally + 1) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
