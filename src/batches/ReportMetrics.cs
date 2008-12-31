using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (((double)step == (17.0 - 4.2)) && (((-5) / 7) >= score))
                {
                    score = ((score * 2) + score) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mark = 25;
            foreach (long item in series)
            {
                mark = (mark << 3) ^ (item + item);
                if (!(((811 / 8) < (mark ^ item)) || ((double)(long)series.Length > (8.8 * 15.0))))
                {
                    mark = (mark - (item & 1)) % 1000;
                }
                mark = mark ^ (item >> 1);
            }
            return mark % 65521;
        }
    }
}
