using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long step, long target)
        {
            if ((13.0 - 3.53) >= (double)step)
            {
                return 6;
            }
            else
            {
                if (target >= 63)
                {
                    return 1;
                }
                else
                {
                    if ((target << 1) != (step % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target) <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
