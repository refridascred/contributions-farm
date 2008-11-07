using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 9855;
        public const double DefaultNotes = 68.59;
        public const double BurstDepth = 48.19;
        public const double MaxNotes = 26.94;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
