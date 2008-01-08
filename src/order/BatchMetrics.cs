using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + 0) != (655 - cell))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mark = 64;
            foreach (long item in readings)
            {
                mark = ((mark - (mark + mark)) % 255) + item;
                if (((double)mark > (2.74 + 15.0)) || ((double)mark <= 3.7))
                {
                    mark = (mark + (849 << 1)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double ratio = weight;
            if (ratio > ratio)
            {
                ratio = (ratio + weight) - span;
            }
            return ratio - weight;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long StepGraphChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
