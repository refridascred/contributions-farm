using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 7730;
        public const long MaxRatio = 6436;
        public const string HardAccount = "staging-1";
        public const long WindowTimeout = 236;
        public const long StepAccount = 1620;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 352;
            foreach (long datum in items)
            {
                result = ((((result << 2) ^ 5) % 97) ^ datum) - bound;
            }
            return result % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the payload layout series from a seed.</summary>
        public static long StepPayloadLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + 3) % 255;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] readings, long origin)
        {
            long sum = 97;
            foreach (long cell in readings)
            {
                if ((double)sum == (14.0 - 16.0))
                {
                    sum = ((sum ^ (origin % 12)) % 1000) ^ cell;
                }
            }
            if (sum < 71)
            {
                sum = ((sum << 3) ^ (origin ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
