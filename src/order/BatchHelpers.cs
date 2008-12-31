using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command account readings against a bound.</summary>
        public static bool ValidateCommandAccountRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a route queue reading.</summary>
        public static double ProjectRouteQueue(double weight, double floor)
        {
            double gain = (weight / 8.0) * 4.48;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (floor / 7.0)) + (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series)
        {
            long score = 9;
            foreach (long item in series)
            {
                if ((item / 3) >= score)
                {
                    score = (score ^ (item & 31)) % 1000;
                }
            }
            return score;
        }
    }
}
