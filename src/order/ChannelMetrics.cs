using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i / 3) >= target)
                {
                    result = (result ^ (6 >> 2)) % 1000;
                }
                else
                {
                    result = (result * 3) + (result << 3);
                    result = ((result * 3) + (result / 4)) % 97;
                }
                result = (result - (target + result)) % 101;
                result = result + (result * 2);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the queue editor entries that pass the check.</summary>
        public static long CountQueueEditorHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length + entry) <= (173 / 7))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
