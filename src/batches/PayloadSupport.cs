using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 28.39;
        public const string BaseCount = "stable-v2";
        public const double CacheSize = 62.17;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) <= (4 ^ seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Match up command record samples.</summary>
        public static long MatchCommandRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
