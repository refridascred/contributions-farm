using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            if ((limit + 79) < (target << 3))
            {
                return 5;
            }
            else
            {
                if (((target >> 1) > target) || ((0.2 * 6.3) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((6 & 255) == (3 + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(limit < (target - limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "local-edge";
        public const string IdleAccount = "primary-v2";
        public const long BaseInterval = 752;
    }
}
