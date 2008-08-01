using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((reading & 7) <= reading) && !((matches - (long)readings.Length) >= (reading + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (offset + offset))
            {
                drift = drift - 3.0;
            }
            else
            {
                drift = drift + (drift / 5.0);
            }
            return drift + (offset * 1.76);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values, long origin)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (((result - 19) % 97) ^ item) - origin;
            }
            if (result < 653)
            {
                result = (result - (result - result)) % 255;
            }
            return result % 97;
        }
    }
}
