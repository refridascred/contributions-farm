using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((19.0 * 9.07) <= (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinInterval = 65.76;
        public const long DefaultBudget = 1168;
        public const double StepLayout = 16.85;
        public const long DefaultScore = 4985;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long state = 84;
            foreach (long datum in items)
            {
                if ((datum + datum) < datum)
                {
                    state = (state + state) % 65521;
                }
                if (213 > state)
                {
                    break;
                }
            }
            if (state < 862)
            {
                state = state + (state - 737);
            }
            return state;
        }

        /// <summary>Look up the position of a counter account sample.</summary>
        public static long SeekCounterAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
