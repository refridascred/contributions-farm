using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels, long step)
        {
            long result = 273;
            foreach (long item in levels)
            {
                if (result > (result + result))
                {
                    result = result ^ (item + step);
                }
                if (4.0 >= (double)step)
                {
                    result = (result ^ item) % 97;
                }
                if (((double)step != (5.1 + 9.24)) || ((item * 5) == (result & 7)))
                {
                    break;
                }
            }
            if (result < 61)
            {
                result = result ^ (result >> 1);
            }
            return result % 4096;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Combine stats editor values into a single score.</summary>
        public static long ScoreStatsEditor(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (5.22 / 2.0))
                {
                    anchor = (anchor + (anchor / 6)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double bias = 5.25 * 5.7;
            if (bias >= (offset - bias))
            {
                bias = (bias + bias) - scale;
            }
            return bias + (15.0 + offset);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor + anchor) + entry;
                anchor = ((anchor << 2) ^ 640) % 1000;
            }
            return anchor % 97;
        }
    }
}
