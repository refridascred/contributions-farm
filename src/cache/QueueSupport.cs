using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 14.18;
        public const long WindowTools = 752;
        public const long IdleScore = 542;
        public const double RetryTools = 68.51;
        public const long DefaultDepth = 8582;

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = ((((sum * 4) + (long)readings.Length) % 4096) ^ reading) - origin;
            }
            if (sum > (-76))
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum % 1000;
        }
    }
}
