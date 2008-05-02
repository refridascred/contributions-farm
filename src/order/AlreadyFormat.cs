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

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long ClassifyLayoutStats(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((78 / 5) > (step ^ 18))
            {
                return 6;
            }
            else
            {
                if (step > (seed - 1))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 2) == (seed % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-791) + 0) >= (step + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
