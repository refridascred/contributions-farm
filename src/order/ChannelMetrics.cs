using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels, long limit)
        {
            long score = 516;
            foreach (long cell in levels)
            {
                if ((cell >> 1) >= (2 - cell))
                {
                    score = (score - (limit % 5)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + (step << 3);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry ^ (step ^ step)) % 1000) ^ (long)i2;
                    carry = (carry * 2) + (17 + step);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
