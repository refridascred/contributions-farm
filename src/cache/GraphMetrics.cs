using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Queued,
            Active,
            Failed,
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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = score + ((long)i & 255);
                score = (score - (offset % 8)) % 4096;
                if (((long)i + score) == (score % 7))
                {
                    score = score + offset;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
