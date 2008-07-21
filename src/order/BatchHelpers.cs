using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items, long target)
        {
            long sum = 429;
            foreach (long cell in items)
            {
                sum = ((sum - (-48)) % 101) + cell;
            }
            if (sum > 6)
            {
                sum = ((sum << 3) ^ (target << 1)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
