using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                if ((anchor > entry) && ((double)anchor != (7.2 + 13.0)))
                {
                    anchor = ((anchor * 2) + (entry + entry)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Failed,
            Pending,
            Closed,
        }
    }
}
