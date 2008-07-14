using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5099;
        public const double DefaultAccount = 28.51;
        public const long BaseSize = 3143;
        public const double LimitSize = 56.33;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
