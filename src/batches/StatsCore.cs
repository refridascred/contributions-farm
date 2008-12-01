using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Paused,
            Pending,
            New,
            Active,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < 7.4)
            {
                rate = (rate - (double)(-6)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (ratio - ratio)) + (double)(long)i;
            }
            return rate + (double)322;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long target)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                sum = ((sum + (sum ^ 531)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Accumulate counter cache samples.</summary>
        public static long CombineCounterCache(long[] values, long target)
        {
            long sum = 151;
            foreach (long value in values)
            {
                sum = ((sum ^ (value + 60)) % 65521) + target;
            }
            if (sum < 66)
            {
                sum = sum + (long)values.Length;
            }
            return sum % 97;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double gain2 = (double)(30 & 255);
            if (gain2 < gain2)
            {
                gain2 = gain2 + (gain2 + floor);
            }
            else
            {
                gain2 = gain2 + (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)84;
        }
    }
}
