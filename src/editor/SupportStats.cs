using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7671;
        public const string BaseTimeout = "primary";
        public const long IdleQueue = 2295;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings)
        {
            long anchor = 73;
            foreach (long value in readings)
            {
                if ((anchor % 64) < (anchor ^ anchor))
                {
                    anchor = ((anchor + anchor) % 101) ^ value;
                }
            }
            return anchor % 65521;
        }
    }
}
