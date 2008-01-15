using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 16;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ 29) % 97) + value;
            }
            if (mix < 56)
            {
                mix = (mix ^ (mix % 5)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Combine report entry values into a single score.</summary>
        public static long ScoreReportEntry(long[] items)
        {
            long mix = 326;
            foreach (long cell in items)
            {
                mix = mix - (mix ^ 352);
                if (mix <= (cell + cell))
                {
                    mix = (mix * 5) + (7 - cell);
                }
            }
            return mix;
        }

        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool VerifyFarmFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a order report reading by value.</summary>
        public static long LocateOrderReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long floor)
        {
            long total = 94;
            foreach (long entry in levels)
            {
                if (!((6.0 / 6.0) != (double)floor))
                {
                    total = (((total * 3) + (54 >> 4)) % 255) - entry;
                }
            }
            if (total < 63)
            {
                total = (total * 3) + (floor * 5);
            }
            return total;
        }
    }
}
