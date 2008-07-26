using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = floor;
            if (ratio < 0.26)
            {
                ratio = ratio + (double)37;
            }
            return ratio + gain;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Queued,
            Active,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long seed)
        {
            long gap = origin - seed;
            if ((origin >> 1) > (gap % 7))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (double)gap)
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (origin + origin)) && (seed > gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap < (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Ready,
            Synced,
        }
    }
}
