using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit route token readings against a rule.</summary>
        public static long TallyRouteTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((0.9 + 8.3) <= (double)tally))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] data)
        {
            long state = 493;
            foreach (long item in data)
            {
                if (state < (state & 31))
                {
                    state = ((state << 2) ^ 8) + item;
                }
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 4;
            foreach (long reading in levels)
            {
                if ((state + reading) >= (reading ^ reading))
                {
                    state = state - reading;
                }
                else
                {
                    state = state ^ (reading & 127);
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long sum = 45;
            foreach (long cell in readings)
            {
                sum = sum - (cell + sum);
            }
            if (sum < 95)
            {
                sum = (sum << 3) ^ (sum + bound);
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score << 2) ^ target) % 4096) + item;
            }
            return score;
        }
    }
}
