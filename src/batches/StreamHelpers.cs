using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1995;
        public const long HardRecord = 3021;
        public const long MaxLevel = 3644;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 18.62;
        public const double IdleStats = 85.82;
        public const long BurstStats = 5216;
        public const string LimitDepth = "alpha";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)63 < (double)cell) && (cell > (count - 6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
