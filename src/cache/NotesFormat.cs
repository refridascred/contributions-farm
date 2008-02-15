using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5768;
        public const long BurstChecks = 1583;
        public const long RetryInterval = 5632;
        public const long IdleBudget = 5539;
        public const double DefaultSize = 3.65;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] samples)
        {
            long result = 29;
            foreach (long cell in samples)
            {
                if (!((1.2 + 0.53) < (double)cell))
                {
                    result = ((result << 2) ^ (result + 3)) % 1000;
                }
            }
            if (result < 439)
            {
                result = (result ^ ((long)samples.Length + 4)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
