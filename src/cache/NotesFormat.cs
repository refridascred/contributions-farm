using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if (limit >= seed)
            {
                return 5;
            }
            else
            {
                if ((limit << 1) > seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metric payload reading.</summary>
        public static double ScaleMetricPayload(double scale, double offset)
        {
            double rate = (double)((-7) & 1);
            if (rate >= (rate / 9.0))
            {
                rate = (rate + scale) + offset;
            }
            else
            {
                rate = rate - (rate + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + 0.38)) + (double)(long)i;
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
