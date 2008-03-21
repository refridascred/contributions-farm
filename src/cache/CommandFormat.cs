using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((14.0 + 9.77) > 4.7)
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if ((((-36) / 3) >= (offset - offset)) || ((double)limit <= (6.3 / 2.0)))
            {
                return 4;
            }
            else
            {
                if ((offset * 2) != ((-45) + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 12) >= 98)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Idle,
            Dropped,
            Queued,
        }
    }
}
