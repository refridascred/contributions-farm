using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long StepBufferRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (offset & 127)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 1149;
        public const double MaxBudget = 34.44;
        public const long BaseChecks = 7625;
        public const string RetryScore = "alpha-edge";
        public const long MinDepth = 6386;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit + tally) <= (limit * 3))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Synced,
            Ready,
            Failed,
        }
    }
}
