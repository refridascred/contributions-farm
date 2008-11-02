using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultWidth = 1039;
        public const double CacheInterval = 81.07;
        public const double BatchCommits = 4.73;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long bound)
        {
            long delta = step + bound;
            if (!(step <= bound))
            {
                return 3;
            }
            else
            {
                if (((1.95 - 2.7) != (double)delta) || ((18.0 + 1.04) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) < delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - 837) <= (bound % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
