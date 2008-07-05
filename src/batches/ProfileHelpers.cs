using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double mean = (double)3 + (double)45;
            if (mean < mean)
            {
                mean = ((mean - (mean / 5.0)) + ratio) + floor;
            }
            return mean - 14.0;
        }

        /// <summary>Locate a route session reading by value.</summary>
        public static long LookupRouteSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double mean = (double)(152 & 255);
            if (mean > (double)18)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (span + 13.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (tally & 127)))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }
    }
}
