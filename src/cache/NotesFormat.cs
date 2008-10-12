using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double weight2 = (1.65 - span) * 8.0;
            if (weight2 < (11.0 * 1.7))
            {
                weight2 = (weight2 + (span * 0.3)) - weight;
            }
            else
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - (double)0;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >= (seen + seen)) && ((seen / 9) < (92 + datum)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long TotalMetricBatches(long[] readings)
        {
            long result = -745;
            foreach (long cell in readings)
            {
                result = ((result + (69 & 1)) % 4096) - cell;
            }
            return result;
        }
    }
}
