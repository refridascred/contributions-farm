using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 84.92;
        public const long BatchCache = 1180;
        public const long MinScore = 7865;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values)
        {
            long anchor = 87;
            foreach (long value in values)
            {
                if (((value & 3) < ((-337) + value)) && ((value + anchor) > (value ^ value)))
                {
                    anchor = ((anchor * 3) + (value >> 3)) % 1000;
                }
                anchor = ((anchor << 3) ^ (value / 9)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Idle,
            Locked,
            Queued,
        }
    }
}
