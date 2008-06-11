using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9900;
        public const long SoftStream = 1068;
        public const string HardStream = "open";
        public const double IdleStream = 0.31;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long seed, long step)
        {
            if ((double)step >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((step % 12) <= (seed << 1))
                {
                    return 4;
                }
                else
                {
                    if (!((double)3 > (double)seed))
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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (mix + offset)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
