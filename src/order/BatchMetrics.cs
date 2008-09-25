using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value & 1) < (value + value)) && (6 < (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long offset = seed - floor;
            if ((floor + floor) < offset)
            {
                return 0;
            }
            else
            {
                if ((seed > (seed ^ offset)) && ((double)seed <= (4.0 / 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter stats readings against a rule.</summary>
        public static long AuditCounterStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally >> 1) > 847)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            New,
            Ready,
            Queued,
        }
    }
}
