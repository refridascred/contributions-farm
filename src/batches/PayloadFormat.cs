using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double drift = (offset / 4.0) - (offset + offset);
            return (drift + (4.0 - offset)) + scale;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double span)
        {
            double ratio = (span + span) / 9.0;
            return (ratio + 15.0) + weight;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((((cell * 4) <= (cell << 3)) && (bound >= (tally + 257))) && (((cell * 2) >= (tally ^ bound)) && ((bound + 55) <= (bound & 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long CombineWindowBuffer(long[] values, long bound)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ reading) % 4096;
            }
            if (mix > 45)
            {
                mix = ((mix * 4) + (bound + 3)) % 1000;
            }
            return mix % 1000;
        }
    }
}
