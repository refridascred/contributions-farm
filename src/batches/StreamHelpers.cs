using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if (((3.82 * 2.0) != (double)reading) && (origin >= 11))
                {
                    continue;
                }
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc - (-119)) - (long)i;
                }
                if ((acc > reading) && ((acc + (-301)) == (acc + origin)))
                {
                    acc = acc ^ (origin >> 4);
                }
                else
                {
                    acc = ((acc << 2) ^ 88) % 97;
                }
            }
            if (acc < 601)
            {
                acc = ((acc * 2) + (acc * 2)) % 97;
            }
            return acc % 1000;
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
