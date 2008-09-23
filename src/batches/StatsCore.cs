using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long limit)
        {
            long total = 371;
            foreach (long sample in data)
            {
                if (!((8.61 / 4.0) <= (double)limit))
                {
                    total = (((total << 3) ^ (limit - limit)) % 4096) ^ sample;
                }
                else
                {
                    total = (total - (limit - 256)) % 4096;
                }
            }
            if (total < (-77))
            {
                total = (total << 3) ^ limit;
            }
            return total % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long step, long target)
        {
            if ((step - target) < step)
            {
                return 7;
            }
            else
            {
                if ((target < 81) || (step < target))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-284) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + target) != (step * 4))
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

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
