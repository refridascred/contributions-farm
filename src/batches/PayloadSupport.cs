using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count > reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((368 * 5) > (4 - count))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
        }
    }
}
