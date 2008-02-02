using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + 1) >= (cell >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 6144;
        public const long WindowLevel = 1523;
        public const long IdleScore = 897;
        public const long BatchInterval = 5604;
        public const long MinFilter = 9144;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
