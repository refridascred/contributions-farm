using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long floor)
        {
            if (((double)floor <= (2.26 / 6.0)) || (limit >= 32))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (105 <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-396) << 1) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 73.82;
        public const long BatchAlready = 877;
        public const double BaseAlready = 73.95;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
