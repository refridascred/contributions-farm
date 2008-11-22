using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool ValidateLayoutMetricsBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a record context sample.</summary>
        public static long LocateRecordContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
