using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 26.49;
        public const string SoftChecks = "alpha-edge";
        public const long SoftCount = 3859;
        public const double BaseSpan = 4.83;
        public const long DefaultChecks = 509;

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double load = floor;
            if (load >= (double)44)
            {
                load = load - (double)(-356);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (gain * 6.0)) + (double)(long)i;
            }
            return load - (gain - gain);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long step)
        {
            long diff = target + step;
            if ((target + step) >= (step * 2))
            {
                return 3;
            }
            else
            {
                if (step < (step / 4))
                {
                    return 8;
                }
                else
                {
                    if ((767 + 290) <= (diff - diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target < (5.0 * 0.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
