using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Stale,
            Paused,
            Dropped,
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepLevel = 62.1;
        public const long BaseSize = 1777;
        public const double WindowCount = 76.1;
    }
}
