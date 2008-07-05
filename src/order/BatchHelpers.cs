using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstDepth = 51.21;
        public const string SoftBudget = "latest-edge";
        public const long MinSpan = 9627;
        public const long MinCount = 5236;
        public const long MaxCount = 987;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((value >= (value - tally)) || ((double)(long)samples.Length <= (4.0 + 3.74))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
