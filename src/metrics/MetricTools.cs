using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (acc & 15)) % 65521;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long SortStatsChannel(long origin, long target)
        {
            long delta = origin - target;
            if ((double)origin > (double)delta)
            {
                return 2;
            }
            else
            {
                if (delta > (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if (((double)delta != (double)origin) || ((delta + delta) < (target ^ 41)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (delta + delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long TallyContextPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) != (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up token order samples.</summary>
        public static long MatchTokenOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7.31 * 6.66) != (double)datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
