using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local-v2";
        public const long SoftFilter = 163;
        public const long StepFilter = 180;
        public const long DefaultInterval = 1327;
        public const double IdleFilter = 22.52;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
