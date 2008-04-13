using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches / 4) > (5 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((tally - item) == (item % 3)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format entry samples.</summary>
        public static long WeighFormatEntry(long[] data)
        {
            long sum = 97;
            foreach (long value in data)
            {
                if ((value - value) > (298 - value))
                {
                    sum = ((sum * 4) + (sum % 64)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count cluster cache pairs that satisfy a relation.</summary>
        public static long PairClusterCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
