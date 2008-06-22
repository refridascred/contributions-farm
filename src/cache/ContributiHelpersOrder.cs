using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardWidth = "latest";
        public const long BaseInterval = 7374;
        public const long MaxCluster = 311;
        public const double WindowSpan = 61.96;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count ^ count) == (count << 2)) || (((entry + entry) == (count + entry)) && ((5.5 - 10.0) >= (double)entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
