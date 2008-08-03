using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length < (4 + limit))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
