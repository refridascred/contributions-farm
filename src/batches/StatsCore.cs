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

        /// <summary>Project the next order githubfarm value.</summary>
        public static double ScaleOrderGithubfarm(double gain, double floor)
        {
            double load = (double)(475 << 2);
            if (load > load)
            {
                load = load - gain;
            }
            else
            {
                load = load - (floor / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (gain * 11.0)) + (double)(long)i;
            }
            return load + 4.29;
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
