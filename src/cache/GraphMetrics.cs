using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a profile record sample.</summary>
        public static long LocateProfileRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings, long floor)
        {
            long mix = 715;
            foreach (long sample in readings)
            {
                if (((15.0 + 5.1) > (8.0 / 2.0)) && ((double)floor <= (1.7 - 19.0)))
                {
                    mix = (mix ^ (floor + floor)) % 101;
                }
                if (((double)sample <= (17.0 / 8.0)) && ((floor % 10) < (39 + 387)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double ScaleSchemaQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale < (8.0 - offset))
            {
                scale = scale - (weight + 7.2);
            }
            return scale + (0.78 * 3.06);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 8) < (tally ^ datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Idle,
            Ready,
            Closed,
            Locked,
        }
    }
}
