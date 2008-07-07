using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset + offset) + (4.1 - rate);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 9.97) + (double)(long)i;
            }
            return bias - (9.1 - offset);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((seen + seen) > datum) && (datum <= (seen & 7))) || ((152 ^ 89) != (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the queue layout entries that pass the check.</summary>
        public static long MeasureQueueLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample <= (seen >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Closed,
            Stale,
            Retry,
        }
    }
}
