using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long step)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = ((score + (896 + score)) + entry) + step;
            }
            return score;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long limit)
        {
            long total = 5;
            foreach (long item in levels)
            {
                total = total ^ item;
                if ((total >> 3) == (293 / 4))
                {
                    total = ((total * 4) + (limit & 7)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5236;
        public const string MaxContext = "stable-1";
        public const double MinRatio = 93.73;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
