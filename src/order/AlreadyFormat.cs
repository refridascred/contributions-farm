using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long limit)
        {
            long gap = bound - limit;
            if ((gap & 127) == (limit ^ bound))
            {
                return 1;
            }
            else
            {
                if ((limit & 15) > (gap << 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (8.8 - 5.73))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double span)
        {
            double gain = bias - (span * 1.49);
            return gain + bias;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Paused,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long SeriesOrderStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
