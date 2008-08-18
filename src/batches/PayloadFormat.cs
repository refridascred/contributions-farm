using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double scale = floor - (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 8.0)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen > 9)
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor << 3) ^ (bound + bound)) % 1000) ^ (long)i2;
                }
                anchor = (anchor ^ anchor) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
