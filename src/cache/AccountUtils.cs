using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 77.65;
        public const long LimitInterval = 9181;
        public const double BaseFormat = 47.17;
        public const string MinFormat = "cached-1";

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if (688 <= (origin + (-4)))
                {
                    result = (result ^ ((long)i ^ (long)i)) % 1000;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
