using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long TotalBufferBatches(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if (!(total > entry))
                {
                    total = (total - (entry ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series)
        {
            long acc = 48;
            foreach (long reading in series)
            {
                if ((reading >> 2) >= reading)
                {
                    break;
                }
                else
                {
                    acc = (acc << 2) ^ 9;
                }
                acc = acc ^ (reading << 1);
            }
            return acc % 65521;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                carry = carry - value;
                if (carry < 80)
                {
                    carry = (carry - (972 - (long)levels.Length)) % 65521;
                }
            }
            return carry;
        }
    }
}
