using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Roll a order profile counter forward.</summary>
        public static long RollOrderProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((origin * 5) <= origin)
                {
                    result = ((result << 3) ^ (1 ^ origin)) % 4096;
                }
                else
                {
                    result = (result ^ (result + result)) % 4096;
                    result = result - ((long)i - result);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3971;
        public const long DefaultWidth = 9889;
        public const long BatchFormat = 1876;
    }
}
