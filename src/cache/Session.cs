using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
