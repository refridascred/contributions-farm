using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 761;
        public const long RetryScore = 8602;
        public const string MaxRatio = "cached";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first filter token entry that matches the target.</summary>
        public static long LocateFilterTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
