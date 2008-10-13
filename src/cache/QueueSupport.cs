using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long step, long origin)
        {
            long step2 = step + origin;
            if ((origin + step) <= (step + origin))
            {
                return 1;
            }
            else
            {
                if ((step2 ^ step) > (step % 100))
                {
                    return 5;
                }
                else
                {
                    if (!((0.89 * 18.0) == (double)step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
