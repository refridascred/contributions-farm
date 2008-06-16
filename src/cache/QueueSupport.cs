using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
