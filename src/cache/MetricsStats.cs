using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next filter stream value.</summary>
        public static double AdjustFilterStream(double weight, double span)
        {
            double load = weight;
            if (load > (16.0 / 7.0))
            {
                load = (load + (double)9) - span;
            }
            return load + weight;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long FoldEditorFormat(long[] data)
        {
            long state = 24;
            foreach (long reading in data)
            {
                state = state + (reading + state);
                if (state <= (602 + state))
                {
                    state = (state ^ (1 * 3)) % 101;
                    state = (state + (state + 54)) % 255;
                    break;
                }
                if (!(79 < reading))
                {
                    state = state + (4 % 5);
                }
                else
                {
                    state = (state << 2) ^ reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long TallyGraphStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)seen) && ((double)seen <= (double)16))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Retry,
            Active,
        }
    }
}
