using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((9.2 - 12.0) < (double)count) && (value <= offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if ((offset - 9) != (offset2 % 24))
            {
                return 6;
            }
            else
            {
                if ((offset & 31) == (offset2 - 981))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 >= (6.01 - 0.55))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 2) > offset2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
