using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long target)
        {
            long slot = step + target;
            if (target <= slot)
            {
                return 5;
            }
            else
            {
                if ((double)slot >= (4.9 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((target - step) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long bound)
        {
            if ((double)bound == (1.16 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((bound & 15) <= (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
