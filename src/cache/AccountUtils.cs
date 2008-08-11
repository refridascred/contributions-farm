using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long target)
        {
            if ((target - offset) < (9 + offset))
            {
                return 5;
            }
            else
            {
                if (!((target - offset) <= offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + offset) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-5) ^ target) >= target) || ((target + offset) >= (54 ^ target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report layout readings.</summary>
        public static long ScoreReportLayout(long[] items)
        {
            long mix = 927;
            foreach (long reading in items)
            {
                mix = ((mix - mix) % 4096) + reading;
            }
            if (mix < 4)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}
