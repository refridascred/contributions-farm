using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Rank stats checks input into a small class.</summary>
        public static long GradeStatsChecks(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((5.9 * 0.67) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset < (offset ^ 9))
                {
                    return 1;
                }
                else
                {
                    if (((seed + span) != (seed + 8)) || (seed < (offset % 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = span + (1.1 * 3.7);
            if (gain2 > (double)410)
            {
                gain2 = gain2 - (span / 9.0);
            }
            return gain2 + gain;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
