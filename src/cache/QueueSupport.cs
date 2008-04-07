using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long floor)
        {
            long step = offset - floor;
            if ((step / 7) < 7)
            {
                return 8;
            }
            else
            {
                if ((double)step < (0.2 - 7.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long carry = -396;
            foreach (long item in readings)
            {
                if ((carry / 4) <= (carry & 255))
                {
                    carry = ((carry ^ (item ^ item)) % 4096) + seed;
                }
                if ((double)carry != (double)item)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
