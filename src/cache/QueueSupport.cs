using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long step2)
        {
            long slot = step - step2;
            if (!((slot - step) <= slot))
            {
                return 5;
            }
            else
            {
                if ((double)slot > (6.7 * 4.44))
                {
                    return 4;
                }
                else
                {
                    if ((step2 << 2) <= (step2 & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step <= (4.0 - 9.16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Idle,
            Paused,
            New,
            Active,
        }
    }
}
