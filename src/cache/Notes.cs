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

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
