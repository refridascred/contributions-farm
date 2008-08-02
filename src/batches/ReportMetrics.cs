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

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long seed, long origin)
        {
            long next = seed + origin;
            if ((53 ^ origin) <= seed)
            {
                return 4;
            }
            else
            {
                if (!((double)465 == (double)next))
                {
                    return 1;
                }
                else
                {
                    if ((16.0 * 4.9) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
