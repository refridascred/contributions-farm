using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up command payload samples.</summary>
        public static long MatchCommandPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstFactor = 394;
        public const string StepWidth = "open-1";
        public const long MaxInterval = 265;
        public const long StepRatio = 2325;
    }
}
