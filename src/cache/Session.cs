using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double gain = 17.0;
            if (gain > (span + ratio))
            {
                gain = gain - ratio;
            }
            return gain + gain;
        }

        /// <summary>Count notes batch pairs that satisfy a relation.</summary>
        public static long PairNotesBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every batches window entry stays within the limit.</summary>
        public static bool CheckBatchesWindowLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
