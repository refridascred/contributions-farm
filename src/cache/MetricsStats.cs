using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long anchor = -8;
            foreach (long item in readings)
            {
                anchor = (anchor - (item + item)) % 1000;
                if ((floor ^ anchor) >= ((-9) + 363))
                {
                    break;
                }
            }
            if (anchor > 304)
            {
                anchor = ((anchor << 3) ^ (floor * 3)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double scale = rate;
            if (scale < rate)
            {
                scale = (scale + scale) - span;
            }
            return scale - 5.0;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Locked,
            Done,
            Pending,
        }
    }
}
