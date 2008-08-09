using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long CountAccountContributiOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((8.52 * 9.0) > (double)sample)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long target)
        {
            long score = 804;
            foreach (long value in readings)
            {
                if (target < score)
                {
                    score = (((score * 3) + (score - target)) % 1000) ^ value;
                }
            }
            if (score > 3)
            {
                score = score ^ (score << 2);
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data, long seed)
        {
            long mix = -451;
            foreach (long item in data)
            {
                mix = (((mix - ((long)data.Length << 3)) % 97) + item) + seed;
            }
            return mix % 1000;
        }
    }
}
