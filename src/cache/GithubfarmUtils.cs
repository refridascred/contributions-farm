using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 2440;
        public const string LimitContributi = "alpha-edge";
        public const long MaxRatio = 8132;
        public const long SoftContributi = 8536;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((sum * 2) + sum) % 1000;
                if ((sum > (sum % 100)) || ((double)sample >= (0.1 - 2.0)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long limit)
        {
            long result = -58;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (509 + limit)) % 97) ^ cell;
            }
            return result;
        }
    }
}
