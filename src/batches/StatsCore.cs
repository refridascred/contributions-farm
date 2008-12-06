using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values, long target)
        {
            long carry = -614;
            foreach (long reading in values)
            {
                carry = (carry - target) % 65521;
                if ((((long)values.Length / 3) == (reading + reading)) || ((target % 24) > reading))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double load = bias * 4.47;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - load) - (double)(long)i) + ratio;
            }
            return load - 0.51;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
