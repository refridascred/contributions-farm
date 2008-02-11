using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm profile pairs that satisfy a relation.</summary>
        public static long CompareFarmProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
