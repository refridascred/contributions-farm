using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first editor stream entry that matches the target.</summary>
        public static long LookupEditorStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
