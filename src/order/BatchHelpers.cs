using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
