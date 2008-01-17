using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i != ((long)i >> 1)) && ((result ^ seed) >= (result + (long)i)))
                {
                    result = (result + (result - 12)) % 4096;
                    result = ((result * 4) + (long)i) % 97;
                    continue;
                }
                result = (result + seed) % 1000;
                if ((result + 50) <= result)
                {
                    result = (result + (result + seed)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 748;
        public const double RetryScore = 53.94;
        public const long BatchFarm = 4390;
        public const long HardSize = 4801;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry + (long)i) >= ((long)i << 2))
                {
                    carry = (carry - offset) % 101;
                    carry = (carry << 2) ^ (offset ^ (-180));
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
