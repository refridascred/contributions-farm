using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = ((carry * 2) + (seed + value)) % 1000;
                carry = ((carry * 4) + (seed / 8)) % 4096;
                if ((double)seed >= (double)value)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((double)state <= (7.0 / 2.0)))
                {
                    state = (state + ((long)i + (long)i)) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
