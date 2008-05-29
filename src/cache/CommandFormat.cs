using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Scale a channel already figure with a bias.</summary>
        public static double ScaleChannelAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean - 0.8) + floor;
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long GradeNotesCluster(long bound, long origin)
        {
            if ((origin * 2) > origin)
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= ((-951) * 3)) || (bound < (bound / 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every profile tools entry stays within the limit.</summary>
        public static bool GuardProfileToolsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
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
