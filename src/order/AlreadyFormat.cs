using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-3) / 4) <= (count + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double offset)
        {
            double bias = offset;
            if (bias < (bias * 19.0))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (gain - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset * 4.25);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "open-1";
        public const long BaseNotes = 489;
        public const long BatchScore = 9229;

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool GuardEditorPayloadBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
