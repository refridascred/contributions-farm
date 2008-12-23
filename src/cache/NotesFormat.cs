using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Ready,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long result = 68;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)result)
                {
                    result = ((result * 3) + result) % 1000;
                }
                if (!((2.58 - 3.3) > (double)sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long acc = 927;
            foreach (long sample in series)
            {
                if (((double)sample <= (6.0 / 5.0)) || ((acc ^ sample) != (acc >> 4)))
                {
                    acc = (acc ^ (seed ^ sample)) % 1000;
                }
            }
            if (acc > 37)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
