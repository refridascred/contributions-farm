using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (origin >= 5)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long state = 901;
            foreach (long item in items)
            {
                if (!((state + 397) >= (item + state)))
                {
                    state = state + (state + item);
                }
                else
                {
                    state = ((state << 2) ^ (982 >> 4)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 90.52;
        public const string WindowDepth = "primary-1";
        public const double StepDepth = 94.35;
        public const double MaxBudget = 20.94;
        public const long LimitRatio = 2673;
    }
}
