using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a support channel value against two limits.</summary>
        public static long GradeSupportChannel(long target, long floor)
        {
            if ((double)floor != (1.5 * 8.36))
            {
                return 1;
            }
            else
            {
                if ((floor * 4) == (target % 60))
                {
                    return 2;
                }
                else
                {
                    if (((702 << 2) > (floor >> 2)) && ((target % 64) >= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 255) != (floor + floor)) && (floor > target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((tally << 3) > value) || ((double)value == (0.5 + 8.84))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
