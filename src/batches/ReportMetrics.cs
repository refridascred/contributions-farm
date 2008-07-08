using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double offset)
        {
            double scale = (double)(-7) / 4.0;
            if (scale < (rate / 5.0))
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (offset + scale);
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool CheckChecksFarmRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
