using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            New,
            Paused,
            Queued,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Stale,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long target)
        {
            long edge = step - target;
            if ((double)step <= (6.48 / 7.0))
            {
                return 3;
            }
            else
            {
                if (!((edge + target) < (target << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge < (double)70)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target & 255) >= edge) && ((step >> 1) <= (584 ^ step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
