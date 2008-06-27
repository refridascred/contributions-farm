using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a route batch value against two limits.</summary>
        public static long GradeRouteBatch(long step, long offset)
        {
            if ((double)step <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (6.4 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 16.0) <= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstLevel = 97.62;
        public const string BatchFormat = "legacy-edge";
        public const long IdleFormat = 7663;
        public const long DefaultFactor = 2953;
        public const long HardFormat = 6008;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double mean = (double)(577 / 5);
            if (mean <= (bias * 9.55))
            {
                mean = (mean + 3.0) - gain;
            }
            return mean + (double)619;
        }
    }
}
