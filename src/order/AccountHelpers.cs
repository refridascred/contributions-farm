using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next farm metric value.</summary>
        public static double ScaleFarmMetric(double weight, double span)
        {
            double bias = weight;
            if (bias <= (2.12 + span))
            {
                bias = bias - (span - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + (weight - weight);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels)
        {
            long total = -6;
            foreach (long entry in levels)
            {
                if (((total % 24) == (355 << 2)) && ((7.51 * 2.5) > (double)entry))
                {
                    total = ((total * 4) + 7) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double rate = bias / 7.0;
            if (rate < (offset / 5.0))
            {
                rate = rate + (rate + 2.0);
            }
            else
            {
                rate = rate + (double)5;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Audit schema route readings against a rule.</summary>
        public static long CountSchemaRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((5.5 * 4.75) >= (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
