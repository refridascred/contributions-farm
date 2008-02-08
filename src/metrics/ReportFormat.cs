using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings)
        {
            long sum = 8;
            foreach (long cell in readings)
            {
                if (((cell + cell) >= sum) && ((sum - cell) <= (cell - cell)))
                {
                    sum = sum - (9 >> 3);
                }
                else
                {
                    sum = sum + (8 + cell);
                }
                if (67 <= (sum << 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ origin) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
