using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count context counter pairs that satisfy a relation.</summary>
        public static long PairContextCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= datum)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long result = 72;
            foreach (long datum in readings)
            {
                result = ((result * 3) + (datum >> 2)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "cached-edge";
        public const long MaxSession = 8453;
        public const double RetryScore = 77.15;
        public const long BatchLevel = 8262;
        public const long IdleSession = 275;
    }
}
