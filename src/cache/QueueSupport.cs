using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] items)
        {
            long anchor = 609;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (anchor >> 1)) - entry;
            }
            return anchor;
        }

        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long FindProfileMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long target)
        {
            long slot = floor + target;
            if (slot <= (target ^ target))
            {
                return 6;
            }
            else
            {
                if (target <= (65 * 2))
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 1) > (642 ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot << 3) >= (slot + 63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
