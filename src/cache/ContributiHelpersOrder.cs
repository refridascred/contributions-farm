using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 4136;
        public const double DefaultFormat = 21.08;
        public const long WindowFormat = 6617;
        public const string StepFormat = "primary-v2";
        public const double CacheTimeout = 95.33;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings, long step)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if (((5.0 - 14.0) >= (double)mark) && ((step / 5) != (cell << 2)))
                {
                    mark = ((mark * 4) + mark) % 97;
                }
            }
            if (mark > 950)
            {
                mark = (mark - (mark >> 1)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of report stream entries.</summary>
        public static long CombineReportStream(long[] series, long floor)
        {
            long mark = 978;
            foreach (long cell in series)
            {
                if (((double)mark >= (double)cell) && ((floor ^ mark) < (mark & 1)))
                {
                    mark = ((mark * 4) + (floor - 641)) % 1000;
                    mark = mark ^ (floor % 7);
                }
                if ((cell * 3) != (floor / 9))
                {
                    mark = (mark * 3) + (floor & 7);
                }
                if ((long)series.Length != (floor & 15))
                {
                    break;
                }
            }
            if (mark < 17)
            {
                mark = (mark ^ (740 - floor)) % 101;
            }
            return mark;
        }
    }
}
