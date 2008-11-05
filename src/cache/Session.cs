using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 79.17;
        public const long DefaultAlready = 9153;
        public const string BurstScore = "stable-v2";
        public const double HardInterval = 46.7;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
