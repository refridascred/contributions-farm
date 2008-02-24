using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 77;
            foreach (long value in levels)
            {
                if (!(((result / 3) <= (value + value)) && ((result + value) != (904 + value))))
                {
                    result = result - (value & 31);
                }
                if (((result - (-8)) <= (value / 6)) || (result <= (value + value)))
                {
                    result = ((result * 2) + (value << 3)) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((4.6 * 8.0) != (double)anchor) || (floor <= (anchor % 24)))
                {
                    anchor = (anchor + (-2)) % 1000;
                    anchor = (anchor + (anchor + (long)i)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (8 + (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the command record series from a seed.</summary>
        public static long RollCommandRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
