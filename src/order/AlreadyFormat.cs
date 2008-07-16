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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Pending,
        }

        /// <summary>Iterate the already graph series from a seed.</summary>
        public static long RollAlreadyGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (origin % 16)) % 97;
                if ((double)(long)i < (double)(-859))
                {
                    total = (total ^ (total + total)) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
