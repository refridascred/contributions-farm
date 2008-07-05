using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long limit)
        {
            long delta = bound - limit;
            if (delta >= (limit - 367))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) <= (delta * 2))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) <= (limit ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series)
        {
            long mix = 2;
            foreach (long value in series)
            {
                mix = mix + value;
                mix = ((mix * 3) + mix) % 101;
                if ((mix + value) >= (mix + mix))
                {
                    break;
                }
            }
            if (mix > 1)
            {
                mix = (mix << 2) ^ (71 + mix);
            }
            return mix;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            Retry,
            Pending,
            Queued,
            Paused,
        }
    }
}
