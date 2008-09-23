using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double offset)
        {
            double gain = ratio * 9.75;
            if (gain > (gain + offset))
            {
                gain = gain + (double)5;
            }
            else
            {
                gain = gain + (gain - offset);
            }
            return gain - (double)(-571);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values, long bound)
        {
            long score = 97;
            foreach (long item in values)
            {
                if (((16.0 / 5.0) <= (double)item) || ((double)bound > (12.0 + 7.7)))
                {
                    score = score + (item + bound);
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long target)
        {
            long carry = 61;
            foreach (long datum in series)
            {
                carry = (((carry * 5) + (7 / 4)) % 1000) + datum;
            }
            if (carry > 28)
            {
                carry = (carry + (161 ^ target)) % 255;
            }
            return carry % 65521;
        }
    }
}
