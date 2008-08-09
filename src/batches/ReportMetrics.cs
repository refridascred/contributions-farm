using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long state = 358;
            foreach (long value in levels)
            {
                state = ((((state * 2) + (state & 3)) % 1000) + value) + bound;
            }
            if (state > 1)
            {
                state = (state ^ ((long)levels.Length * 3)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
