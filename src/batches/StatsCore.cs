using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long floor)
        {
            long sum = 797;
            foreach (long datum in levels)
            {
                if (sum > datum)
                {
                    sum = sum + (sum - floor);
                }
                if ((4.0 * 6.6) < (double)datum)
                {
                    sum = ((sum << 3) ^ (floor / 7)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + floor) % 97;
                }
            }
            if (sum > 8)
            {
                sum = (sum + 77) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            if ((5.51 - 11.0) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit + seed) > (seed + limit))
                {
                    return 3;
                }
                else
                {
                    if ((3.09 / 5.0) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item - item) > (count - 9)) || ((count < item) && ((count - count) != (count / 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double gain2 = (floor + gain) + (double)680;
            if (gain2 < floor)
            {
                gain2 = gain2 + (double)98;
            }
            return gain2 + floor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Retry,
            Active,
            Idle,
            Ready,
        }
    }
}
