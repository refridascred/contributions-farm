using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first session checks entry that matches the target.</summary>
        public static long LookupSessionChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) < (57 + 8))
                {
                    tally = ((tally + 2) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Rank route account input into a small class.</summary>
        public static long ClassifyRouteAccount(long step, long floor)
        {
            long edge = step ^ floor;
            if ((floor + edge) != (floor + step))
            {
                return 7;
            }
            else
            {
                if ((645 + step) <= (450 << 3))
                {
                    return 3;
                }
                else
                {
                    if ((7 >> 3) > edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (step - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
