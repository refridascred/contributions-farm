using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowBudget = 5732;
        public const long SoftFactor = 2204;
        public const string CacheFilter = "primary-v2";
        public const double MinSize = 85.33;

        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long SeriesMetricsCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score - (step * 4)) % 1000) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every metric notes entry stays within the limit.</summary>
        public static bool ValidateMetricNotesLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long floor)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if (((floor ^ reading) < mark) || ((reading + mark) <= reading))
                {
                    mark = (mark + reading) % 255;
                }
                if ((double)reading <= (14.0 + 8.2))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (reading + 199)) % 1000;
                }
                if ((reading - floor) > (reading % 3))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Pending,
            Synced,
            Paused,
        }
    }
}
