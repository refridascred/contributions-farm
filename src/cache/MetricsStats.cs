using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i - limit) != (carry / 9)) && ((carry - limit) > ((long)i - 8)))
                {
                    carry = carry - (carry % 8);
                }
                carry = carry ^ (carry - carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
