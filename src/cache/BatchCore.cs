using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 4) != ((-480) & 255))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Scale a command profile figure with a bias.</summary>
        public static double ProjectCommandProfile(double gain, double span)
        {
            double scale = (double)(130 - (-994));
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + span;
            }
            return scale + (double)52;
        }

        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long MeasureToolsEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen * 5) >= (62 & 3)) || ((seen >> 4) < value)) || ((seen > (seen + value)) && ((value * 2) >= (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
