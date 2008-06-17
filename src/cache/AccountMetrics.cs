using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value <= (hits + value))
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

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                if ((item - 285) <= anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - 31) % 97;
                    anchor = anchor + (origin << 2);
                }
                if ((origin * 5) >= (origin * 4))
                {
                    anchor = anchor + 77;
                }
            }
            if (anchor > (-18))
            {
                anchor = (anchor << 3) ^ (origin * 3);
            }
            return anchor % 1000;
        }
    }
}
