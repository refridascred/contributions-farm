using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (((double)delta < (2.0 + 12.0)) || ((origin + delta) <= (delta >> 1)))
            {
                return 8;
            }
            else
            {
                if ((double)seed < 9.8)
                {
                    return 6;
                }
                else
                {
                    if (!((double)16 >= (double)delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 3) != (9 ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSize = 9958;
        public const string SoftReport = "stable-v2";
        public const long BatchReport = 1015;
        public const long IdleReport = 5671;
        public const long LimitSize = 8713;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
