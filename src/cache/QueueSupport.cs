using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command record counter forward.</summary>
        public static long StepCommandRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long BucketFarmQueue(long target, long floor)
        {
            long edge = target ^ floor;
            if (((floor * 4) != (edge - target)) || ((target + (-42)) < ((-67) - floor)))
            {
                return 8;
            }
            else
            {
                if ((edge * 2) != (edge & 255))
                {
                    return 2;
                }
                else
                {
                    if (!((21 + floor) <= (edge + 957)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge > (2.41 + 1.7)) || ((67 - target) < (96 - edge)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Dropped,
            Closed,
            Retry,
            Paused,
        }
    }
}
