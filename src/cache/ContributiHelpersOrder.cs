using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double span)
        {
            double mean = 9.0;
            if (mean > (8.0 / 3.0))
            {
                mean = (mean + span) - rate;
            }
            return mean - (mean * 8.1);
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long target)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = ((total << 3) ^ item) % 255;
            }
            if (total < 689)
            {
                total = (total << 2) ^ (target - total);
            }
            return total % 65521;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
