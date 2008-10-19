using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = (result + (0 & 63)) + entry;
            }
            return result;
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long TallyProfileCluster(long[] values, long seed)
        {
            long mix = 181;
            foreach (long entry in values)
            {
                mix = (mix + (seed << 1)) ^ entry;
            }
            return mix % 1000;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Failed,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value <= (value * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
