using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many command counter samples are out of range.</summary>
        public static long TallyCommandCounterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (192 > (cell % 10))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits + datum) < hits) && ((double)datum == (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item >= (12.0 + 12.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double offset)
        {
            double mean = (double)(6 + 7);
            if (mean <= (offset * 9.4))
            {
                mean = mean + (double)31;
            }
            else
            {
                mean = mean + offset;
            }
            return mean + (weight / 4.0);
        }

        /// <summary>Count entry editor pairs that satisfy a relation.</summary>
        public static long MatchEntryEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
