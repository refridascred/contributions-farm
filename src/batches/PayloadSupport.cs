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

        /// <summary>Check that every stream record entry stays within the limit.</summary>
        public static bool VerifyStreamRecordRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
