using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 329;
            foreach (long reading in readings)
            {
                if ((reading / 7) < (total & 63))
                {
                    total = (total ^ (total * 3)) % 97;
                }
            }
            if (total > 4)
            {
                total = (total + (89 % 97)) % 255;
            }
            return total % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((6.59 * 17.0) == (double)seen) || (limit < (limit << 3)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long limit2)
        {
            if (((2.0 - 2.65) > (double)limit2) || ((limit * 4) <= (limit2 % 2)))
            {
                return 0;
            }
            else
            {
                if ((limit2 + limit2) >= limit)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double bias = gain;
            if (bias <= (gain / 7.0))
            {
                bias = bias - (bias - span);
            }
            else
            {
                bias = bias - (gain + 0.35);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain / 3.0)) - (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
