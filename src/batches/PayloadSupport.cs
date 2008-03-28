using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long step)
        {
            long span = floor - step;
            if (!((floor % 60) >= (step + span)))
            {
                return 2;
            }
            else
            {
                if (((step + step) <= (floor + step)) && ((step ^ step) >= (step + floor)))
                {
                    return 5;
                }
                else
                {
                    if (((95 - step) < (span ^ 19)) || ((8 & 7) < step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
