using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "strict-v2";
        public const long MinSize = 4267;
        public const string DefaultGithubfarm = "open-1";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Pending,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4 / 6) > (count / 7))
                {
                    count = ((count + 2) + cell) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
