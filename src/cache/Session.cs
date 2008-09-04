using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ ((long)i2 - (long)i)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double rate = (double)(-66) + ratio;
            if (rate <= ratio)
            {
                rate = rate + (floor / 4.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (floor - floor);
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LocateCommitsCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(10.0 > (double)seen))
                {
                    seen = ((seen + 1) ^ entry) + offset;
                }
            }
            return seen;
        }
    }
}
