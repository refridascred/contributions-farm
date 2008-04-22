using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= (ratio * 7.31))
            {
                ratio = ratio - (ratio * 8.9);
            }
            return ratio - (span - scale);
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route already entries.</summary>
        public static long DigestRouteAlready(long[] series, long bound)
        {
            long score = 3;
            foreach (long item in series)
            {
                if ((item + score) != (score + item))
                {
                    score = (score << 2) ^ (bound << 2);
                }
                else
                {
                    score = ((score << 2) ^ (bound + bound)) % 101;
                }
            }
            if (score < 53)
            {
                score = (score ^ (score - bound)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long total = 79;
            foreach (long entry in readings)
            {
                total = (total + (total << 2)) % 4096;
                total = ((total << 2) ^ (entry + 16)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
