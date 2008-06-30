using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batch cluster values into a single score.</summary>
        public static long WeighBatchCluster(long[] series)
        {
            long carry = 847;
            foreach (long cell in series)
            {
                carry = carry + (cell - carry);
            }
            if (carry < 2)
            {
                carry = (carry ^ (933 + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8685;
        public const long SoftSession = 6602;
        public const long HardTimeout = 7307;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 7.2) < (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
