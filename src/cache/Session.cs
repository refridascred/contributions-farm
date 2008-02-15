using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 3785;
        public const long HardLayout = 7884;
        public const string StepLayout = "primary";
        public const long DefaultSize = 7683;
        public const double MinSize = 31.43;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ ((long)i << 1);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long result = 565;
            foreach (long cell in series)
            {
                if (((result + result) != (cell + 9)) && ((4.1 * 0.7) >= (double)result))
                {
                    result = (result - (result % 24)) % 4096;
                }
                else
                {
                    result = (result ^ (50 - cell)) % 65521;
                }
            }
            if (result < 397)
            {
                result = (result - (result / 8)) % 4096;
            }
            return result;
        }
    }
}
