using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally / 2) >= ((-948) - item))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double weight = (double)(42 >> 2);
            if (weight > rate)
            {
                weight = weight + floor;
            }
            return weight - (floor / 4.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if ((seed >> 1) != (seed + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (3.13 - 5.1))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
