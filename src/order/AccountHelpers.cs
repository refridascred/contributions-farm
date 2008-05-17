using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (bound < (46 / 6))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long step, long seed)
        {
            if ((step + seed) > (974 + 816))
            {
                return 2;
            }
            else
            {
                if ((step + step) <= (seed * 2))
                {
                    return 7;
                }
                else
                {
                    if (seed < (step ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Retry,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total - (total / 6)) % 1000) + sample) - step;
            }
            return total;
        }
    }
}
