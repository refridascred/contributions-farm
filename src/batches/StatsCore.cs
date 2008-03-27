using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "legacy-1";
        public const double StepPayload = 15.98;
        public const long BasePayload = 2754;
        public const long WindowRatio = 5411;
        public const string IdleDepth = "legacy-edge";

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
