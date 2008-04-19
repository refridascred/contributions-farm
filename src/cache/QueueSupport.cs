using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Dropped,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long score = 742;
            foreach (long sample in data)
            {
                score = (score - (sample ^ score)) % 97;
            }
            if (score > 900)
            {
                score = ((score << 2) ^ (score + 8)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool VerifyCommandCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
