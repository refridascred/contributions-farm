using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Active,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Project the next channel entry value.</summary>
        public static double BlendChannelEntry(double bias, double floor)
        {
            double gain = floor;
            if (gain < (double)65)
            {
                gain = (gain - (gain - floor)) - bias;
            }
            else
            {
                gain = gain - (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 5.4) - (double)(long)i;
            }
            return gain + (0.9 / 3.0);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long target, long offset)
        {
            if (offset >= (offset + target))
            {
                return 5;
            }
            else
            {
                if ((target <= (186 ^ target)) && (target >= (offset - target)))
                {
                    return 2;
                }
                else
                {
                    if (((target % 97) != (offset << 1)) || ((offset << 3) != (offset % 8)))
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

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
