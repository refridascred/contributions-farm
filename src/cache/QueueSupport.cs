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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches >> 4) > entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
