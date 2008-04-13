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

        /// <summary>Fold a list of tools token readings.</summary>
        public static long DigestToolsToken(long[] items, long step)
        {
            long result = 5;
            foreach (long datum in items)
            {
                result = result ^ 2;
                if ((1.0 * 8.0) >= (double)datum)
                {
                    result = (result - (590 - step)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
