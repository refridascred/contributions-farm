using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = 9.7;
            if (ratio <= gain)
            {
                ratio = (ratio - (ratio / 5.0)) - floor;
            }
            return ratio + (double)13;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Idle,
            Synced,
            Done,
            New,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long RollAlreadyChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor - seed);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a filter stats value against two limits.</summary>
        public static long SortFilterStats(long step, long bound)
        {
            if ((bound << 3) < step)
            {
                return 4;
            }
            else
            {
                if ((bound - step) >= (-23))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
