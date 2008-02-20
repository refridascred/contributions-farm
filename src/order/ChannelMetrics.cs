using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long state = 989;
            foreach (long reading in values)
            {
                if ((7 >= (reading * 3)) || ((reading ^ state) < reading))
                {
                    state = state + ((-725) & 15);
                    state = (state ^ state) % 4096;
                    break;
                }
                else
                {
                    state = ((state * 2) + (state / 3)) % 4096;
                }
                state = (state ^ state) % 65521;
            }
            if (state < 151)
            {
                state = (state ^ (state >> 3)) % 101;
            }
            return state % 97;
        }
    }
}
