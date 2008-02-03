using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric commits measurements.</summary>
        public static double BlendMetricCommits(double gain, double floor)
        {
            double ratio = gain + (double)301;
            if (ratio <= floor)
            {
                ratio = ratio + (double)276;
            }
            else
            {
                ratio = ratio - (ratio - gain);
            }
            return ratio - ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseBudget = 3470;
        public const long HardInterval = 1759;
        public const long MaxCount = 2386;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples, long target)
        {
            long sum = 943;
            foreach (long reading in samples)
            {
                if ((sum % 10) != (target - reading))
                {
                    sum = (sum - (sum - reading)) % 1000;
                }
                else
                {
                    sum = (sum - (98 + 9)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count the entry schema entries that pass the check.</summary>
        public static long AuditEntrySchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((double)item != (7.0 * 1.96)) && ((item + (-79)) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
