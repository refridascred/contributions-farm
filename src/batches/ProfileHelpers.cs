using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first filter already entry that matches the target.</summary>
        public static long SeekFilterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > (bias2 / 8.0))
            {
                drift = (drift - drift) - bias;
            }
            return drift - drift;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double gain = bias + floor;
            if (gain < (double)3)
            {
                gain = gain + gain;
            }
            return gain + (bias + gain);
        }
    }
}
