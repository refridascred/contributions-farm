using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of notes batches entries.</summary>
        public static long TotalNotesBatches(long[] levels)
        {
            long total = 829;
            foreach (long reading in levels)
            {
                if ((double)reading > (13.0 + 7.72))
                {
                    total = total - reading;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const double DefaultBuffer = 78.02;
        public const string SoftLevel = "strict-edge";

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain - span)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value <= (6.0 + 0.02))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
