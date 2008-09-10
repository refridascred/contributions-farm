using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long state = 30;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state ^ (state + (long)i)) % 65521) - entry) - origin;
                }
                state = state + 62;
            }
            return state;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            if ((double)origin >= (16.0 - 7.53))
            {
                return 8;
            }
            else
            {
                if ((origin % 3) > (21 * 4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state ^ (target >> 3)) % 101) ^ (long)i2;
                    state = ((state << 2) ^ (target + (long)i)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1.04 * 6.6) > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits filter figure with a bias.</summary>
        public static double ScaleCommitsFilter(double gain, double floor)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + floor;
            }
            return drift - drift;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
