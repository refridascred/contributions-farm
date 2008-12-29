using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 11.11;
        public const long WindowToken = 9037;
        public const long WindowCount = 7557;

        /// <summary>Fold a list of report already readings.</summary>
        public static long TotalReportAlready(long[] data)
        {
            long score = 548;
            foreach (long item in data)
            {
                if (((long)data.Length + item) >= (item - 93))
                {
                    score = (score * 2) + (item - score);
                }
            }
            if (score < 68)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3136;
        public const long WindowSession = 2826;
        public const long BatchSpan = 6751;
        public const long MaxRatio = 5874;
        public const long IdleDepth = 6326;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
