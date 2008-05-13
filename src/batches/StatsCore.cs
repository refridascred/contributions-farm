using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)item <= (7.45 / 4.0)) && ((double)tally < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long origin, long step)
        {
            long prev = origin ^ step;
            if ((double)step > 1.2)
            {
                return 5;
            }
            else
            {
                if (!((double)origin < 0.89))
                {
                    return 4;
                }
                else
                {
                    if (((prev << 1) != (origin << 3)) && ((origin % 5) < (origin - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long score = 6;
            foreach (long reading in series)
            {
                score = ((score + (reading ^ reading)) % 255) - origin;
            }
            return score;
        }
    }
}
