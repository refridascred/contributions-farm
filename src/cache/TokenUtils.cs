using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (floor - 413))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
