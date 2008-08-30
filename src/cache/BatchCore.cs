using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the channel session entries that pass the check.</summary>
        public static long AuditChannelSessionHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + hits) < origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long origin)
        {
            if ((origin - origin) < origin)
            {
                return 7;
            }
            else
            {
                if (((limit >> 3) > limit) && (limit > (1 & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 7) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Ready,
            Done,
            Pending,
            Dropped,
        }
    }
}
