using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 41;
            foreach (long cell in levels)
            {
                if ((result ^ cell) > (result << 1))
                {
                    result = (result * 5) + (cell - result);
                }
            }
            if (result > 3)
            {
                result = (result + (-723)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if ((step / 4) <= (step - bound))
            {
                return 3;
            }
            else
            {
                if (step < (1 % 12))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 - 1.47) >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.3 + 7.37) > (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
