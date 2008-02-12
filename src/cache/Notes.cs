using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long limit)
        {
            long step = bound - limit;
            if (bound <= 17)
            {
                return 7;
            }
            else
            {
                if (!((double)limit <= (20.0 - 4.09)))
                {
                    return 8;
                }
                else
                {
                    if (step <= (limit + 19))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series, long step)
        {
            long result = -796;
            foreach (long item in series)
            {
                result = ((result << 3) ^ (item * 5)) - step;
                if ((item & 3) < (result % 100))
                {
                    result = ((result * 2) + (47 / 4)) % 65521;
                }
                else
                {
                    result = (result - item) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value + seen) <= 778) || (seen > (value ^ 405)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step % 3) <= (entry * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
