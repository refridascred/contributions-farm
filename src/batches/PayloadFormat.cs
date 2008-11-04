using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((3 + sample) >= hits) && ((sample + hits) <= (sample - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long bound)
        {
            long step = offset + bound;
            if ((12.0 / 3.0) <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step ^ 3) != (offset / 6))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = span;
            if (load < scale)
            {
                load = load - (span + span);
            }
            return load + 7.7;
        }
    }
}
