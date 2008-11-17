using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8476;
        public const double DefaultFactor = 8.43;
        public const double LimitCount = 56.6;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 198;
            foreach (long sample in samples)
            {
                score = score + (7 + sample);
            }
            return score % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-648) >> 1) > (item ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
