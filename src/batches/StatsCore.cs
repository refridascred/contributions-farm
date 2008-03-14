using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits * 2) <= offset)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Paused,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long step)
        {
            if ((step ^ origin) <= origin)
            {
                return 4;
            }
            else
            {
                if (((origin - (-880)) >= (818 ^ origin)) || (origin < (origin / 7)))
                {
                    return 7;
                }
                else
                {
                    if (((step ^ step) > (step - origin)) && ((-7) > (step + origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many cache stream samples are out of range.</summary>
        public static long TallyCacheStreamHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((69 % 64) != (79 + item))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
