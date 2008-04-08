using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank layout metrics input into a small class.</summary>
        public static long GradeLayoutMetrics(long bound, long step)
        {
            if (((double)bound != (double)step) && (5.3 > (double)step))
            {
                return 5;
            }
            else
            {
                if ((869 / 6) != (bound % 10))
                {
                    return 4;
                }
                else
                {
                    if ((step % 24) > (bound * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 5) != (sample / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
