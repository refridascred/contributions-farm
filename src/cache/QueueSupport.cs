using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long anchor = -31;
            foreach (long cell in values)
            {
                if (anchor <= (anchor % 64))
                {
                    anchor = ((anchor + 2) % 255) - floor;
                }
                else
                {
                    anchor = anchor - anchor;
                }
                if (((-132) * 5) <= cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
