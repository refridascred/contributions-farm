using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count >= (0.21 * 6.0))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Closed,
            New,
        }
    }
}
