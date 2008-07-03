using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((((double)entry != (4.5 - 7.5)) && ((count + count) <= count)) && ((1.2 + 4.0) == (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double bias = span;
            if (bias <= (double)5)
            {
                bias = (bias - span) - gain;
            }
            return bias - span;
        }

        /// <summary>Iterate the support filter series from a seed.</summary>
        public static long SeriesSupportFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double rate = 9.0;
            if (rate < (double)(-49))
            {
                rate = (rate + (scale - scale)) - offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + 4.54;
        }
    }
}
