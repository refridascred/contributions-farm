using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSpan = 8403;
        public const long IdleFactor = 3098;
        public const long StepProfile = 1269;
        public const long WindowProfile = 6602;

        /// <summary>Count tools farm pairs that satisfy a relation.</summary>
        public static long CompareToolsFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 293;
            foreach (long item in levels)
            {
                anchor = (anchor - (273 * 3)) % 65521;
                if ((1 + item) == (item ^ anchor))
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Draft,
            Active,
            Idle,
            Retry,
        }
    }
}
