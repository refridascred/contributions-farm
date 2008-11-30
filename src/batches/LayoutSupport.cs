using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double rate = bias;
            if (rate < floor)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (bias - floor);
            }
            return rate - (double)952;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool GuardLayoutToolsLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long mark = 72;
            foreach (long value in values)
            {
                mark = ((mark << 3) ^ value) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Paused,
            Ready,
            Dropped,
        }
    }
}
