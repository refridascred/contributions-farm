using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long bound)
        {
            if (!(bound <= (bound >> 5)))
            {
                return 0;
            }
            else
            {
                if ((step % 12) < (-146))
                {
                    return 4;
                }
                else
                {
                    if (!(9.49 < (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (907 >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = 19;
            foreach (long entry in samples)
            {
                if ((9.0 / 7.0) >= (double)entry)
                {
                    total = (total + entry) % 1000;
                }
            }
            return total;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((state >= origin) && (6.98 > (double)origin)))
                {
                    state = (state - (long)i) % 101;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long MeasureCommandNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading / 9) > tally) && (((reading + reading) <= (reading % 24)) && (tally < (tally + reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
