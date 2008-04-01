using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 5504;
        public const double MaxFactor = 55.64;
        public const long MaxSize = 7163;
        public const long WindowWidth = 3309;
        public const long DefaultRecord = 1367;

        /// <summary>Validate session layout readings against a bound.</summary>
        public static bool CheckSessionLayoutRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
