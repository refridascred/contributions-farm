using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long target)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                if (((target / 4) >= target) && ((target >> 5) <= target))
                {
                    mix = (mix - (reading + reading)) % 101;
                }
                else
                {
                    mix = (mix - 566) % 97;
                }
            }
            if (mix > 24)
            {
                mix = (mix - (target % 97)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 5209;
        public const double CacheInterval = 49.05;
        public const double BaseWidth = 10.06;
        public const long CacheCount = 7706;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long floor)
        {
            long lane = bound + floor;
            if ((floor + floor) < 751)
            {
                return 1;
            }
            else
            {
                if (((2.5 / 9.0) > (double)floor) && ((bound & 3) < (lane + floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
