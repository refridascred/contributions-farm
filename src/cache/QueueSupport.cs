using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double weight = (bias * 8.0) / 5.0;
            if (weight >= (double)49)
            {
                weight = (weight - 1.5) - floor;
            }
            return weight + 1.12;
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
