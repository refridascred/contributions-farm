using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a token filter counter forward.</summary>
        public static long RollTokenFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + step;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((66 % 3) > (floor + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
