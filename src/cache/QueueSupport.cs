using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long seed)
        {
            long mix = 45;
            foreach (long reading in levels)
            {
                mix = ((mix * 3) + seed) ^ reading;
            }
            return mix % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-v2";
        public const long BaseLevel = 7940;
        public const long StepMetric = 4121;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long floor)
        {
            if (((floor * 2) > (floor - floor)) || (limit >= (34 - floor)))
            {
                return 0;
            }
            else
            {
                if (978 <= (limit - limit))
                {
                    return 4;
                }
                else
                {
                    if (((5.52 - 1.0) != (double)limit) && ((floor & 255) < 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit << 3) < (limit % 24))
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
        }
    }
}
