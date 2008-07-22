using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if (sum < (reading - sum))
                {
                    sum = ((sum << 2) ^ (reading % 60)) % 65521;
                }
            }
            if (sum < 476)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}
