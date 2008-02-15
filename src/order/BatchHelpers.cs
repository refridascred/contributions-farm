using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a commits context value against two limits.</summary>
        public static long SortCommitsContext(long bound, long origin)
        {
            long offset = bound - origin;
            if (!((double)origin <= (double)bound))
            {
                return 3;
            }
            else
            {
                if (!((origin ^ 878) <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 3) != (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + origin) == (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Done,
            Stale,
        }
    }
}
