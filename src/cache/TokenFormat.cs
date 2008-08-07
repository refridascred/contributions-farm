using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long floor)
        {
            if ((double)bound >= (1.5 * 7.75))
            {
                return 5;
            }
            else
            {
                if (!((bound + bound) == (bound / 6)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
