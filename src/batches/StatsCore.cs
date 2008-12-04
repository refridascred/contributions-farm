using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool CheckLayoutContributiLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowScore = 8597;
        public const long RetryBuffer = 9569;
        public const long BaseCount = 9937;
        public const long DefaultCount = 4207;

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long MeasureStreamCounterOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value / 7) > target) && ((tally / 6) != (target / 5))) || ((tally ^ tally) > (tally - 68)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window layout value from a seed.</summary>
        public static long StepWindowLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 2) ^ ((long)i - anchor);
                if ((9.84 + 0.4) >= (double)anchor)
                {
                    anchor = (anchor * 2) + ((long)i - anchor);
                    anchor = (anchor * 3) + limit;
                }
                if ((double)anchor >= 6.06)
                {
                    anchor = ((anchor << 3) ^ (limit * 2)) % 1000;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool GuardPayloadProfileLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a record queue counter forward.</summary>
        public static long SeriesRecordQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = (score << 3) ^ (long)i;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
