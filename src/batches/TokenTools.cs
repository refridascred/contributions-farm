using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)(long)samples.Length >= 4.4) && ((3.5 + 17.0) > (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
