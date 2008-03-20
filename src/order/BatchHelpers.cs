using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count != (6.7 / 2.0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool VerifyCommandOrderBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
