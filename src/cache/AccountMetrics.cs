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

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

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

        /// <summary>Fold a list of command order readings.</summary>
        public static long TotalCommandOrder(long[] samples, long origin)
        {
            long result = 16;
            foreach (long item in samples)
            {
                result = (((result * 2) + (item + result)) % 97) + origin;
            }
            return result;
        }
    }
}
