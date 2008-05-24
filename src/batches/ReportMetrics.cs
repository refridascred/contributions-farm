using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 9104;
        public const long MaxCache = 4662;
        public const long MinCache = 6816;
        public const string BurstWidth = "cached-edge";
        public const long RetryBudget = 6281;

        /// <summary>Project the next batches counter value.</summary>
        public static double AdjustBatchesCounter(double gain, double offset)
        {
            double weight = offset + (10.0 + offset);
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit > total) || ((limit << 2) < total))
                {
                    total = (total + (-9)) % 1000;
                }
                if (limit <= 306)
                {
                    total = (total - (total & 31)) % 97;
                }
                else
                {
                    total = (total * 2) + ((long)i + (long)i);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
