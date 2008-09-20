using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up tools farm samples.</summary>
        public static long MatchToolsFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long target)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if (((4.8 * 0.14) > (double)value) && ((8 + value) <= (result * 5)))
                {
                    result = ((result * 2) + (50 * 2)) + target;
                }
            }
            return result % 4096;
        }
    }
}
