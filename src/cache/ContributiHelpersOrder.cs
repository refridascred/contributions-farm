using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepInterval = "latest-edge";
        public const long IdleLevel = 31;
        public const long HardBuffer = 3141;
        public const long WindowTimeout = 7393;
        public const long WindowSpan = 8021;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
