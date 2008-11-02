using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values)
        {
            long result = 37;
            foreach (long datum in values)
            {
                result = ((result * 5) + (datum & 3)) % 101;
            }
            if (result < 32)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count <= (4.95 / 9.0))
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
