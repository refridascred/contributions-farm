using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long FoldNotesMetrics(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if ((mark / 7) <= reading)
                {
                    mark = (mark ^ (mark - 4)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark + (mark + 35)) % 1000;
                }
                if (((mark + mark) >= mark) || (reading >= (17 + mark)))
                {
                    mark = (mark + reading) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((double)seen < (14.0 / 8.0)) && ((double)85 <= (double)entry)) && ((step % 64) >= 500))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long SortSupportFarm(long limit, long bound)
        {
            if ((8.42 <= (double)bound) && ((double)limit > (4.0 * 7.0)))
            {
                return 3;
            }
            else
            {
                if (((double)bound == (1.0 * 7.9)) || (limit >= (883 & 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ bound) >= (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 5544;
        public const long BatchFactor = 9443;
        public const long LimitContributi = 6867;

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 82.55;
        public const long LimitNotes = 7529;
        public const long HardNotes = 6646;
    }
}
