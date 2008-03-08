using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((offset - datum) >= offset)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double scale = (0.22 - offset) - 5.1;
            if (scale >= offset)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (double)45) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double gain = (double)(2 ^ 5);
            if (gain < (double)341)
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + ratio;
        }
    }
}
