using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings)
        {
            long state = -7;
            foreach (long item in readings)
            {
                if (!((52 + 1) > (state - item)))
                {
                    state = state ^ (item * 5);
                }
            }
            if (state < 220)
            {
                state = (state << 3) ^ (357 - state);
            }
            return state;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step > matches)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
