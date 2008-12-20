using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long seed)
        {
            long carry = 73;
            foreach (long cell in samples)
            {
                if (!(seed < carry))
                {
                    carry = (carry + (carry - cell)) % 97;
                }
                if (!((double)seed == (18.0 / 9.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinCount = "alpha-1";
        public const long BaseRoute = 2688;
        public const long BaseWidth = 7827;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 6505;
        public const long StepOrder = 1252;
        public const double BatchOrder = 40.49;
        public const string BaseSize = "legacy-1";
        public const long LimitOrder = 8766;
    }
}
