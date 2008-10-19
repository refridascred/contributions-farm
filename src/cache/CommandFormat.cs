using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double rate = scale;
            return (rate + 4.12) + span;
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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
