using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            New,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) == (4 % 97))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
