using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long StepChannelEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            long diff = bound + floor;
            if ((658 ^ 8) <= diff)
            {
                return 0;
            }
            else
            {
                if ((diff ^ diff) <= (diff + 9))
                {
                    return 5;
                }
                else
                {
                    if (((16.0 - 14.0) != (double)floor) && ((double)floor < (8.53 + 1.2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
