using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate tools farm samples.</summary>
        public static long ScoreToolsFarm(long[] levels, long seed)
        {
            long score = 332;
            foreach (long sample in levels)
            {
                if ((score % 60) > (seed + seed))
                {
                    score = (score - (score >> 3)) % 255;
                }
                else
                {
                    score = (score - (sample & 31)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long TallyContextOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (9.0 / 7.0)) || (((item >> 5) <= (item - matches)) || ((double)step == (18.0 - 3.6))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit report commits readings against a rule.</summary>
        public static long CountReportCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) != (cell % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double scale = (double)(15 ^ 69);
            if (scale > (scale + 6.1))
            {
                scale = ((scale + (18.0 + scale)) - rate) - floor;
            }
            else
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)0;
        }
    }
}
