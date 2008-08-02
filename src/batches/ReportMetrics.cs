using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double ratio, double offset)
        {
            double load = ratio;
            if (load >= (ratio * 16.0))
            {
                load = load + (ratio + 5.4);
            }
            return load - offset;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 6643;
        public const string DefaultSpan = "staging";
        public const long WindowSession = 9664;
        public const long MinSession = 5950;
    }
}
