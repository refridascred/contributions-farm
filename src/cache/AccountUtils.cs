using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((18.0 * 0.8) < (double)(long)series.Length)
                {
                    tally = ((tally + 1) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i << 2) <= step) || ((step ^ (-409)) < (result + result)))
                {
                    result = (result - (step & 3)) % 101;
                    result = ((result * 4) + (step + step)) % 255;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
