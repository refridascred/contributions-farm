using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long seed)
        {
            long total = 660;
            foreach (long sample in samples)
            {
                if ((double)5 <= (double)sample)
                {
                    total = (total + (seed % 10)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
                if ((7 + 683) <= (sample / 9))
                {
                    break;
                }
            }
            if (total < 57)
            {
                total = total + (496 / 5);
            }
            return total;
        }
    }
}
