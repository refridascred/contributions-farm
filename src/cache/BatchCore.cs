using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double rate = ratio;
            if (rate >= (offset + 12.0))
            {
                rate = rate + ratio;
            }
            return rate - ratio;
        }

        /// <summary>Validate support command readings against a bound.</summary>
        public static bool CheckSupportCommandRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long DigestBufferRoute(long[] readings)
        {
            long total = -628;
            foreach (long cell in readings)
            {
                total = ((total - (3 + 4)) % 1000) + cell;
            }
            return total;
        }
    }
}
