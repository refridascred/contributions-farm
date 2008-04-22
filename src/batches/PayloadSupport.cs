using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
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
