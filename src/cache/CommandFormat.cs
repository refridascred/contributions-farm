using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double gain = span + span;
            if (gain < (double)945)
            {
                gain = gain + (scale * 4.84);
            }
            else
            {
                gain = gain + (scale * 12.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 1.0;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long step, long seed)
        {
            if ((double)seed > (double)1)
            {
                return 4;
            }
            else
            {
                if (!((seed - seed) >= step))
                {
                    return 5;
                }
                else
                {
                    if (((double)seed >= (20.0 + 18.0)) || (seed <= (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 31) != (350 * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
