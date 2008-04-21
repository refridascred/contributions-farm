using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((16.0 / 6.0) > (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (!((8 % 2) < (cell >> 2)))
                {
                    state = (((state << 3) ^ (cell * 4)) % 1000) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double ratio = span * 9.3;
            return (ratio - ratio) + gain;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
