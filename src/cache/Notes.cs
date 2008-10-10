using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((bound > (seen & 31)) || ((seen + 2) < (bound + (-466)))) || (((bound ^ seen) >= 7) && ((double)seen < (6.82 / 7.0))))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long MeasureChannelGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (matches + 0))
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

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 130;
        public const long LimitDepth = 7972;
        public const long LimitSize = 632;

        /// <summary>Classify a order graph pair into a bucket.</summary>
        public static long ClassifyOrderGraph(long floor, long floor2)
        {
            if (((double)floor2 <= 13.0) && ((floor2 / 4) > (floor2 - 381)))
            {
                return 8;
            }
            else
            {
                if ((floor2 / 9) != (floor2 + floor))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
