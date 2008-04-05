using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] data, long bound)
        {
            long anchor = 874;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (anchor + bound))
                {
                    break;
                }
                anchor = anchor ^ 34;
                if ((4 % 7) <= (entry % 5))
                {
                    anchor = anchor - (entry + bound);
                }
            }
            if (anchor < 807)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor + 406) == (72 - hits))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
