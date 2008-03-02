using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 4.2;
        public const double MinBudget = 5.88;
        public const long DefaultCount = 8704;
        public const double LimitBudget = 74.8;

        /// <summary>Combine window metric values into a single score.</summary>
        public static long FoldWindowMetric(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                if (((double)item > (4.0 / 9.0)) && ((double)item == (2.7 + 16.0)))
                {
                    mix = ((mix << 3) ^ (mix / 6)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (item ^ mix);
                }
            }
            if (mix > 54)
            {
                mix = (mix - (8 & 15)) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSpan = 1151;
        public const double RetrySpan = 18.16;
        public const long BatchTools = 4511;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((-415) + count) >= origin)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
