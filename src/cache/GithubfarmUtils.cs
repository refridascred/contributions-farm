using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSpan = 4244;
        public const double BaseWidth = 7.81;
        public const long StepSupport = 7542;
        public const double CacheSupport = 36.67;
        public const long SoftSpan = 3332;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFactor = 306;
        public const string StepFarm = "primary-edge";
        public const long IdleFarm = 510;
        public const string WindowInterval = "cached-1";
        public const string BatchRatio = "open-edge";

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                carry = ((carry << 3) ^ carry) % 4096;
                if ((double)carry > (double)75)
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (value / 9)) % 1000;
                }
                if (501 <= (value + 8))
                {
                    carry = (carry * 4) + (long)readings.Length;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
