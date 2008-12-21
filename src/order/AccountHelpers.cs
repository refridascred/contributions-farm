using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter format samples.</summary>
        public static long CompareFilterFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a support metric counter forward.</summary>
        public static long RollSupportMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((limit / 3) >= limit))
                {
                    anchor = (anchor * 5) + (anchor ^ anchor);
                    anchor = (anchor - ((-163) ^ limit)) % 4096;
                }
                anchor = anchor ^ (limit >> 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 9687;
        public const long MaxCount = 2622;
        public const double HardWidth = 58.97;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
