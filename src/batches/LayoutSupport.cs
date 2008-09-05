using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + hits) >= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long score = 205;
            foreach (long item in samples)
            {
                score = (score ^ 7) - item;
            }
            if (score > 54)
            {
                score = ((score * 5) + (step + step)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double BlendEditorCommand(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio + (floor - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (4.49 * 2.1)) + (double)(long)i;
            }
            return ratio - (double)5;
        }
    }
}
