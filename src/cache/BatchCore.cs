using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "stable-v2";
        public const long IdleFactor = 9914;
        public const long MaxGraph = 3097;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (7 > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate schema checks readings against a bound.</summary>
        public static bool CheckSchemaChecksBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Synced,
            Failed,
        }
    }
}
