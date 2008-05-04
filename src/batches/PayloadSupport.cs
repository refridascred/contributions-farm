using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long limit2)
        {
            if ((limit << 1) <= (limit2 + limit2))
            {
                return 6;
            }
            else
            {
                if ((limit * 3) < limit2)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 97) <= (4 + limit2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit2) >= (limit2 - limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
