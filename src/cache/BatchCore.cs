using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report format entries that pass the check.</summary>
        public static long AuditReportFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((29 & 1) > (entry * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitCount = 3562;
        public const string LimitFormat = "cached-1";
        public const long WindowCount = 1246;
        public const long HardFormat = 3047;

        /// <summary>Look up the position of a profile batches sample.</summary>
        public static long SeekProfileBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
