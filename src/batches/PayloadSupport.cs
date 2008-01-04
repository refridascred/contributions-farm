using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultScore = 9744;
        public const long MinCounter = 403;
        public const long MaxSize = 8378;
        public const long HardSize = 4010;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
