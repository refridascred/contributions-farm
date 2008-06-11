using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long target)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix * 4) + (sample + 7)) - target;
            }
            if (mix < (-892))
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultWidth = 8166;
        public const string MaxScore = "cached-1";
        public const long WindowLevel = 932;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
