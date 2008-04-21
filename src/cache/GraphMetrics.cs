using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                mix = (((mix * 4) + mix) % 65521) ^ sample;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum ^ matches) >= (datum - 87)) || ((double)matches < 7.51))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(target >= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Active,
            Draft,
            Ready,
            Failed,
        }
    }
}
