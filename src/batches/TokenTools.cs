using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long FindMetricsReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry farm samples.</summary>
        public static long TotalEntryFarm(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                mix = (((mix * 2) + (mix & 31)) % 1000) ^ entry;
                mix = ((mix << 3) ^ ((-23) + mix)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                sum = (sum * 4) + reading;
                sum = (sum - sum) % 1000;
            }
            if (sum > (-351))
            {
                sum = (sum << 3) ^ (long)series.Length;
            }
            return sum;
        }
    }
}
