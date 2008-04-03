using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count <= (count % 7)) && ((count + count) >= (cell / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema stats series from a seed.</summary>
        public static long DeriveSchemaStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = (result * 2) + (origin + (long)i);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
