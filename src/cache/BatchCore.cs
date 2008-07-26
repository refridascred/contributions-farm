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

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long seed, long seed2)
        {
            if (seed > (seed2 % 16))
            {
                return 3;
            }
            else
            {
                if ((seed + seed2) < (seed2 / 6))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed2 != (5.8 * 17.0)) && ((seed2 - seed) < seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (seed - seed))
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
}
