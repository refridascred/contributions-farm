using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (value & 255))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long seed)
        {
            long span = floor - seed;
            if ((seed + span) != (seed - 54))
            {
                return 5;
            }
            else
            {
                if (0 <= (seed + (-52)))
                {
                    return 0;
                }
                else
                {
                    if (((1.0 + 5.5) >= (double)span) && (seed >= (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
