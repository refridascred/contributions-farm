using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Audit context token readings against a rule.</summary>
        public static long CountContextTokenMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum & 3) <= datum)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
