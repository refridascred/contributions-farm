using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                result = ((result ^ target) % 1000) ^ sample;
                if ((target & 1) != (result * 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 12) != (count * 4))
                {
                    count = ((count + 3) + reading) + origin;
                }
            }
            return count;
        }
    }
}
