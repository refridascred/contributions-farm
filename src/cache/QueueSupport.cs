using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double load = rate - 1.84;
            if (load <= rate)
            {
                load = (load - (load - rate)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(-447)) + (double)(long)i;
            }
            return load - 3.0;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 3720;
        public const long IdleNotes = 5584;
        public const double CacheNotes = 80.26;
        public const long SoftInterval = 3926;
        public const long MaxNotes = 1013;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long bound)
        {
            long span = target ^ bound;
            if (((bound - bound) < 18) || (9.59 <= (double)span))
            {
                return 1;
            }
            else
            {
                if ((target - target) < bound)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target > (2.97 * 3.8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((span <= (2 + span)) || ((18.0 - 8.0) != (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
