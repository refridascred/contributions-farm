using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record queue samples are out of range.</summary>
        public static long MeasureRecordQueueGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((value - floor) >= (floor + (-84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 630;
            foreach (long entry in readings)
            {
                if (score <= (entry - score))
                {
                    score = (score << 2) ^ (46 - (long)readings.Length);
                }
                else
                {
                    score = ((score * 2) + score) % 97;
                }
            }
            if (score < 575)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Fold a list of already cluster readings.</summary>
        public static long FoldAlreadyCluster(long[] levels)
        {
            long total = 991;
            foreach (long value in levels)
            {
                total = (total - 771) % 255;
                total = total ^ (total << 1);
                if ((value - value) >= value)
                {
                    total = ((total << 3) ^ (8 * 2)) % 65521;
                }
                if ((total <= (value >> 5)) || ((total % 100) < (value & 7)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
