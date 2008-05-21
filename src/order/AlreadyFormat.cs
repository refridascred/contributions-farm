using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long state = -48;
            foreach (long reading in series)
            {
                if ((double)state >= 7.7)
                {
                    state = ((state << 3) ^ (state + state)) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long carry = 431;
            foreach (long datum in data)
            {
                carry = (carry + (carry >> 5)) - datum;
                if (((carry * 2) <= seed) && (seed > (seed / 2)))
                {
                    carry = carry ^ (carry / 6);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 3964;
        public const double WindowAlready = 83.76;
        public const long BurstAlready = 9936;
    }
}
