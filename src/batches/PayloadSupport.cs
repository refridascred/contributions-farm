using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long total = 9;
            foreach (long item in samples)
            {
                if ((total << 3) != (total + (-95)))
                {
                    total = ((total * 5) + (total - item)) - offset;
                }
            }
            return total;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long score = 0;
            foreach (long value in series)
            {
                score = (((score - (66 ^ score)) % 97) + value) + origin;
            }
            return score % 97;
        }
    }
}
