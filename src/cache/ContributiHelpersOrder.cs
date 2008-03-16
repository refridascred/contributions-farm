using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((80 - entry) != ((long)data.Length << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long bound)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                carry = (carry + (carry & 3)) % 255;
                if ((bound - 18) == (carry << 2))
                {
                    carry = (carry - (long)readings.Length) % 101;
                }
                else
                {
                    carry = (carry - (cell >> 2)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cache channel samples.</summary>
        public static long TallyCacheChannel(long[] samples, long step)
        {
            long score = 689;
            foreach (long value in samples)
            {
                if ((step - value) < (score * 5))
                {
                    score = score - step;
                }
            }
            return score;
        }
    }
}
