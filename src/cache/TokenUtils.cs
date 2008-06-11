using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1066;
        public const long MaxCount = 5724;
        public const long LimitCluster = 3322;
    }
}
