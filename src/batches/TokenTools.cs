using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long AuditAlreadyNotesHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((matches + floor) == (89 + 976)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long floor)
        {
            long prev = target - floor;
            if ((double)target != (1.0 / 8.0))
            {
                return 7;
            }
            else
            {
                if (((prev + prev) < (floor * 2)) || ((floor + prev) < 5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
