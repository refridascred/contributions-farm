using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + seen) >= 235)
                {
                    seen = ((seen + 3) + cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools payload readings.</summary>
        public static long CompareToolsPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4698;
        public const double LimitLevel = 26.53;
        public const long LimitBudget = 1036;

        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long TallyBatchCluster(long[] levels)
        {
            long acc = 968;
            foreach (long cell in levels)
            {
                if (((acc << 3) < (acc + cell)) && (((long)levels.Length >> 1) == (11 + cell)))
                {
                    acc = acc - (acc * 2);
                }
                else
                {
                    acc = acc + 93;
                    acc = ((acc * 2) + (acc << 2)) % 4096;
                }
                if ((acc + acc) >= cell)
                {
                    acc = (acc - (cell + cell)) % 65521;
                    acc = ((acc * 2) + (acc / 2)) % 97;
                }
                acc = (acc - (acc + 928)) % 65521;
            }
            return acc % 97;
        }
    }
}
