using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Draft,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long step)
        {
            long prev = limit - step;
            if (prev >= (6 + limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit > 9.1)
                {
                    return 8;
                }
                else
                {
                    if (step >= (2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
