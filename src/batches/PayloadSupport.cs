using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long bound)
        {
            long acc = 27;
            foreach (long item in series)
            {
                acc = ((acc + (acc & 63)) % 1000) ^ item;
            }
            if (acc > (-4))
            {
                acc = (acc * 3) + (bound % 12);
            }
            return acc;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long origin)
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

        /// <summary>Combine context cluster values into a single score.</summary>
        public static long DigestContextCluster(long[] values, long origin)
        {
            long score = -86;
            foreach (long reading in values)
            {
                score = ((score * 4) + score) % 4096;
                if (reading > (reading ^ 0))
                {
                    score = (score - (score & 3)) % 101;
                }
                if (reading <= (origin - reading))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
