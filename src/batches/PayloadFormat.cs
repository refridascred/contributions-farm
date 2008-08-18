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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step < (6.1 - 6.9))
                {
                    mark = (mark + 293) % 1000;
                    break;
                }
                mark = (mark - (72 * 4)) % 255;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
