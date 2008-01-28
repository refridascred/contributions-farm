using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = score - ((long)i << 2);
                score = (score << 2) ^ floor;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double scale = (double)(201 + 9);
            if (scale >= (gain + offset))
            {
                scale = scale + 6.5;
            }
            else
            {
                scale = scale + (double)2;
            }
            return scale + gain;
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool ValidateBatchesFormatLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
