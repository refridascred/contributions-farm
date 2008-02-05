using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long score = 599;
            foreach (long value in samples)
            {
                score = ((score - score) % 4096) - value;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1687;
        public const long MinAlready = 3085;
        public const double WindowInterval = 96.72;
        public const double MaxAlready = 29.05;
        public const long IdleAlready = 5789;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
