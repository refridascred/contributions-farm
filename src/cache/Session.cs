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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor != (7.7 - 9.48))
                {
                    anchor = ((anchor * 3) + bound) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
