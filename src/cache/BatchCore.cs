using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long limit)
        {
            if ((origin & 127) != (929 & 1))
            {
                return 5;
            }
            else
            {
                if (262 >= (origin >> 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - datum) > (seen - seed))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) <= (0 + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            Closed,
            Synced,
        }
    }
}
