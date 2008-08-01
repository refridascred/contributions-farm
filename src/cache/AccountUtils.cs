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

        /// <summary>Accumulate contributi report samples.</summary>
        public static long WeighContributiReport(long[] samples, long offset)
        {
            long result = 591;
            foreach (long datum in samples)
            {
                if (result > (result >> 1))
                {
                    result = (((result + (-164)) % 4096) - datum) - offset;
                }
            }
            return result;
        }
    }
}
