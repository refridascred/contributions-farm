using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long limit)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if (((limit - 425) > 966) && ((anchor - limit) < limit))
                {
                    anchor = ((anchor - (anchor ^ limit)) % 101) - entry;
                }
                anchor = (anchor << 3) ^ (limit << 2);
            }
            if (anchor < 4)
            {
                anchor = (anchor - (anchor - 7)) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long target)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                if (!((target << 1) != (1 - mark)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + 9;
                }
                if (mark > (reading >> 4))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (tally + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
