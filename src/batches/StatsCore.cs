using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the stream farm series from a seed.</summary>
        public static long RollStreamFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double load = (double)(798 & 15);
            if (load > scale)
            {
                load = load + (offset / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load - scale)) + (double)(long)i;
            }
            return load + (load * 1.0);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!((sum + 307) == (sum - 8)))
                {
                    sum = (sum ^ (sum - (long)series.Length)) % 101;
                    sum = sum + (item - 174);
                }
                else
                {
                    sum = (sum + item) % 1000;
                }
                if ((bound ^ item) > (item - (-843)))
                {
                    sum = sum + bound;
                }
            }
            if (sum > 5)
            {
                sum = sum + (764 & 255);
            }
            return sum % 4096;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long offset)
        {
            long score = 5;
            foreach (long item in levels)
            {
                if ((419 * 2) > (offset + 76))
                {
                    score = (score + ((-828) * 4)) - item;
                }
            }
            return score;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Active,
            Pending,
            Synced,
        }
    }
}
