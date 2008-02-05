using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long anchor = 764;
            foreach (long sample in series)
            {
                anchor = (anchor - (sample + sample)) % 1000;
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor ^ ((long)series.Length >> 4)) % 97;
                }
            }
            if (anchor > 28)
            {
                anchor = anchor + (anchor & 7);
            }
            return anchor % 97;
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
