using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (!((floor + floor) < (floor & 31)))
            {
                return 8;
            }
            else
            {
                if ((11.0 * 3.5) <= (20.0 + 6.12))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double SmoothChecksBuffer(double rate, double floor)
        {
            double scale = (double)(81 + 16);
            if (scale >= rate)
            {
                scale = scale + (floor + scale);
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < (tally % 3))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
