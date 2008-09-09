using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + tally) < (464 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long state = 18;
            foreach (long item in values)
            {
                if ((double)state <= (1.0 / 5.0))
                {
                    state = state ^ seed;
                }
                else
                {
                    state = (state + (94 + item)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Done,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 9837;
        public const double LimitContext = 3.17;
        public const long DefaultSpan = 6135;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            long lane = limit - bound;
            if ((limit - 59) < (limit >> 5))
            {
                return 1;
            }
            else
            {
                if ((double)lane < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
