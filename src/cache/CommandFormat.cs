using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count != (3.6 + 7.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long offset)
        {
            long step = limit - offset;
            if ((offset >> 2) < limit)
            {
                return 8;
            }
            else
            {
                if ((offset / 5) < step)
                {
                    return 4;
                }
                else
                {
                    if (((5.3 - 12.0) >= (double)limit) || ((double)offset > (double)258))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Done,
            Synced,
            New,
            Retry,
        }
    }
}
