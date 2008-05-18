using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardTimeout = "stable-v2";
        public const long StepProfile = 9221;
        public const long BurstInterval = 6973;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetrySize = 57.43;
        public const string LimitCount = "primary-v2";
        public const double MinEditor = 70.53;
        public const double HardEditor = 84.49;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 290;
            foreach (long reading in data)
            {
                if ((reading * 5) >= (total - total))
                {
                    total = (total * 3) + total;
                }
            }
            return total;
        }
    }
}
