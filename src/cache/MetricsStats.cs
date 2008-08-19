using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a farm profile reading.</summary>
        public static double ScaleFarmProfile(double gain, double offset)
        {
            double ratio = offset;
            if (ratio >= (ratio / 6.0))
            {
                ratio = (ratio + (double)2) - gain;
            }
            else
            {
                ratio = ratio + (double)39;
            }
            return ratio - offset;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading + reading) >= (tally + 1)) && ((tally << 3) > (reading * 5))) || ((reading < (reading * 2)) && ((tally - tally) <= tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 42.87;
        public const long BatchFactor = 442;
        public const double SoftScore = 85.86;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Locked,
            Synced,
        }
    }
}
