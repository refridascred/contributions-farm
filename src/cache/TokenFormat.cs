using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mark = 88;
            foreach (long item in samples)
            {
                if ((((-65) + item) == (item * 5)) && ((6.0 * 4.5) <= (double)item))
                {
                    mark = ((mark * 5) + (item + item)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (item * 2);
                }
                mark = (mark - (mark << 2)) % 4096;
            }
            if (mark > 9)
            {
                mark = ((mark * 3) + 551) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Ready,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
