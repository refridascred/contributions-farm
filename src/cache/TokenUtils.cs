using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long acc = 533;
            foreach (long entry in samples)
            {
                if ((acc + acc) >= (entry & 7))
                {
                    acc = (acc - (entry + entry)) % 101;
                }
            }
            if (acc > 801)
            {
                acc = (acc + (5 * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Locked,
            New,
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
