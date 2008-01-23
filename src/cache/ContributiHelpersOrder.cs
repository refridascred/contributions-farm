using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double drift = weight;
            if (drift < 14.0)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (weight - 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (span + drift);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)seed >= (4.0 + 5.0))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
