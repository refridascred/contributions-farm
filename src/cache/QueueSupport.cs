using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry cache samples are out of range.</summary>
        public static long AuditEntryCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen > (19.0 * 3.6))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            if (step > (offset >> 2))
            {
                return 6;
            }
            else
            {
                if ((694 / 4) == (offset - step))
                {
                    return 1;
                }
                else
                {
                    if ((72 & 3) == (step / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 3) != (offset % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
